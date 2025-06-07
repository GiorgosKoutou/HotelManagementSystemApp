using HotelPmsUI.Extensions;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Windows.Markup;

namespace HotelPmsUI.ModelServices
{
    public class BaseService<TModel, TFormCrud, TFormList, TFormFilter>(DataAccessLibrary.Context.HpmsDbContext context) : IService
            where TModel : class where TFormCrud : Form where TFormList : Form where TFormFilter : Form
    {
        internal Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction;

        private int currentPage = 1;
        private int startPoint = 0;
        private int skippedRecords;
        private int recordsPerPage = 30;
        private int totalRecords;
        private int totalPages = 0;
        private int currentIndex = -1;
        private int categoryType;

        private string includeEntity = string.Empty;
        private bool needsInclude = false;

        internal bool isAdded = false;

        internal TModel? initialRecord;
        internal IQueryable<TModel>? records;
        internal EntityEntry? entry;


        internal TFormCrud? formCrud;
        internal TFormList? formList;
        internal TFormFilter? formFilter;
        private Forms.MainForm? mainForm = Program.ServiceProvider?.GetRequiredService<Forms.MainForm>();
        private Control? mainPanel;

        private BindingSource? bindingSource = new();


        public int CurrentPage { get => currentPage; }
        public int CurrentPageIncrement { set => currentPage += value; }
        public int CurrentPageDecrement { set => currentPage -= value; }
        public int StartPointIncrement { set => startPoint += value; }
        public int StartPointDecrement { set => startPoint -= value; }
        public int RecordsPerPage { get => recordsPerPage; }
        public int TotalRecords { get => totalRecords; }
        public int TotalPages { get => totalPages; }

        public int CurrentIndex { get => currentIndex; }

        public BindingSource? BindingSource { get => bindingSource; }
        public DataAccessLibrary.Context.HpmsDbContext Context { get => context; }
        public int CategoryType { get => categoryType; set => categoryType = value; }

        private void CalculatePages()
        {
            totalPages = totalRecords / recordsPerPage;
            totalPages += (totalRecords % recordsPerPage > 0) ? 1 : 0;
            
        }

        private void LoadData()
        {
            records ??= context.Set<TModel>();
            totalRecords = context.Set<TModel>().Count();
            CalculatePages();

            skippedRecords = startPoint * recordsPerPage;
            var entity = records!.Skip(skippedRecords).Take(recordsPerPage).ToList();

            if (entity.Count == 0 && currentPage > 1)
            {
                currentPage--;
                startPoint--;
                skippedRecords = startPoint * recordsPerPage;
                entity = [.. records!.Skip(skippedRecords).Take(recordsPerPage)];
            }

            bindingSource!.DataSource = entity;

        }
               

        public virtual void ViewData()
        {
            try
            {
                LoadData();
            }
            catch (DbException ex)
            {
                string errorMessage = ex.Message;
                MessageBox.Show($"Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mainForm!.NewButton!.Enabled = true;
            mainForm!.EditButton!.Enabled = true;

            ShowListForm();
        }

        public virtual void SaveData()
        {
            try
            {
                transaction = context.Database.BeginTransaction();

                var currentRecord = (TModel)bindingSource!.Current;

                entry = context.Entry(currentRecord);


                if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)
                {
                    context.Add(currentRecord);
                    MessageBox.Show($"{currentRecord.GetType().Name} added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var newRecord = bindingSource?.AddNew();
                    initialRecord = ((TModel)newRecord!).CopyData();
                    bindingSource!.DataSource = initialRecord;
                }
                else
                {
                    context.Update(currentRecord);
                    MessageBox.Show($"{currentRecord.GetType().Name} Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    

                context.SaveChanges();
                transaction.Commit();
            }
            catch (DbUpdateException e)
            {

                string errorMessage = e.InnerException!.Message;
                isAdded = false;
                MessageBox.Show($"Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction?.Rollback();
            }
            

        }

        public virtual void NewData()
        {
            var newRecord = bindingSource?.AddNew();
            initialRecord = ((TModel)newRecord!).CopyData();
            bindingSource!.DataSource = newRecord;

            ShowCrudForm();
        }

        public virtual void EditData()
        {
            var entity = (TModel)bindingSource![currentIndex];
            bindingSource.DataSource = entity;

            ShowCrudForm();
        }


        public virtual void DeleteData()
        {
            var entity = (TModel)bindingSource![currentIndex];

            if(currentIndex == -1)
            {
                MessageBox.Show($"Please select a {entity.GetType().Name}");
                return;
            }

            if(entity == null)
            {
                MessageBox.Show($"{entity?.GetType().Name} not found");
                return;
            }

            context.Set<TModel>().Remove(entity);
            MessageBox.Show($"{entity.GetType().Name} deleted successfully");
            context.SaveChanges();

        }


        public void CheckPage(Control previousButton, Control nextButton)
        {
            if(currentPage == 1)
            {
                previousButton.Enabled = false;
            }

            if(currentPage > 1)
            {
                previousButton.Enabled = true;
            }

            if(currentPage == totalPages)
            {
                nextButton.Enabled = false;
            }
        }

        public virtual void ShowCrudForm()
        {
            formList?.Close();
            mainPanel?.Controls.Clear();

            formCrud = Program.ServiceProvider?.GetRequiredService<TFormCrud>();
            mainForm?.CenterForm(formCrud!);
            formCrud?.ShowDialog();

        }

        public virtual void ShowListForm()
        {
            formCrud?.Close();

            formFilter?.Close();

            mainPanel?.Controls.Clear();

            formList = Program.ServiceProvider?.GetRequiredService<TFormList>();

            formList!.TopLevel = false;
            formList!.TopMost = false;
            formList!.FormBorderStyle = FormBorderStyle.None;
            formList!.Dock = DockStyle.Fill;

            mainPanel?.Controls.Add(formList);
            formList?.Show();
        }

        public virtual void ShowFilterForm()
        {
            formList?.Close();
            mainPanel?.Controls.Clear();

            formFilter = Program.ServiceProvider?.GetRequiredService<TFormFilter>();
            mainForm?.CenterForm(formFilter!);
            formFilter?.ShowDialog();
        }

        public void SetIndex(int index)
        {
            currentIndex = index;
        }

        public void SetPanel(Control panel)
        {
            mainPanel = panel;
        }

        internal void SetRecords<T>(IQueryable<T> records)
        {
            this.records = (IQueryable<TModel>?)records;
        }

        internal StringBuilder CheckFields()
        {
            StringBuilder message = new();
            int count = 0;

            var type = typeof(TModel);

            foreach (var prop in type.GetProperties()) {
                
                var value = prop?.GetValue(bindingSource?.Current);


                if ((prop!.IsDefined(typeof(RequiredAttribute), true) 
                        || prop.IsDefined(typeof(DataAccessLibrary.AttributeMarkerClasses.RequiredForValidation)) )
                        && !IsValid(value!))
                {

                    var displayName = prop?.GetCustomAttribute<DisplayAttribute>()!.Name;
                    string innerMessage = GetMessage(value!);

                    message.AppendLine($"Field: {displayName} {innerMessage}");
                    count++;
                }
            }

            if (count >= 1)
                return message;

            return null!;
        }

        private static bool IsValid(object value)
        {
            var type = value.GetType();
            
            
            if ((type == typeof(int) || type == typeof(long)) && (value is null || value.Equals(0)))
                return false;

            if ((type == typeof(float) || type == typeof(double)) && (value is null || value!.Equals(0.0)))
                return false;

            if (type == typeof(string) && (value is null || string.IsNullOrEmpty(value!.ToString())))
                return false;

            if(type == typeof(object) && value is null)
                return false;

            return true;
        }

        private static string GetMessage(object value)
        {
            string message = string.Empty;

            if (value.GetType() == typeof(int) || value.GetType() == typeof(long))
            {
                message = "cannot be 0";
                return message;
            }
                

            if(value.GetType() == typeof(float) || value.GetType() == typeof(double))
            {
                message = "cannot be 0.0";
                return message;
            }
                

            if (value.GetType() == typeof(string))
            {
                message = "cannot be empty";
                return message;
            }
                
            return null!;
        }

        internal void Filter()
        {
            var predicate = PredicateBuilder.New<TModel>(true);

            var formType = typeof(TFormFilter);

            foreach (var prop in formType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var columnName = string.Empty;

                if (prop!.IsDefined(typeof(DataAccessLibrary.AttributeMarkerClasses.ColumnNames), true))
                {
                    var rawValue = prop?.GetValue(formFilter);
                    columnName = prop!.GetCustomAttribute<DataAccessLibrary.AttributeMarkerClasses.ColumnNames>()!.Name;
                    var query = PredicateQuery(predicate, rawValue!, prop!, columnName!, includeEntity, needsInclude);

                    if(query is null)
                        continue;

                    predicate = query; 

                }
                    
            }

            List<TModel> filteredTable = null!;


            if (needsInclude)
                filteredTable =  [.. context.Set<TModel>().Where(predicate).Include(i => EF.Property<object>(i, includeEntity))];
            else
                filteredTable = [.. context.Set<TModel>().Where(predicate)];

            if (filteredTable.Count == 0)
            {
                var modelName = typeof(TModel).Name;
                MessageBox.Show($"{modelName} not found!");
            }
                

            bindingSource!.DataSource = filteredTable;
            ShowListForm();
            needsInclude = false;
        }

        private Expression<Func<TModel, bool>> PredicateQuery(Expression<Func<TModel, bool>> predicate, object value,
                                                              PropertyInfo prop,
                                                              string columnName,
                                                              string includeEntity,
                                                              bool needsInclude)
        {

            if (value is string)
            {
                var stringValue = value.ToString();

                if (string.IsNullOrEmpty(stringValue)) 
                    return null!;

                if (stringValue!.Contains('*'))
                    stringValue = stringValue.Replace('*', '%');


                if (!string.IsNullOrEmpty(stringValue) && stringValue.Contains('%'))
                {
                    predicate = predicate.And(x => EF.Functions.Like(EF.Property<string>(x, columnName!), stringValue));
                    return predicate;
                }

                if (!string.IsNullOrEmpty(stringValue) && prop!.Name.Contains("From"))
                {
                    predicate = predicate.And((x => String.Compare(EF.Property<string>(x, columnName!), stringValue) >= 0));
                    
                }
                else if (!string.IsNullOrEmpty(stringValue) && prop!.Name.Contains("To"))
                {
                    predicate = predicate.And(x => String.Compare(EF.Property<string>(x, columnName!), stringValue) <= 0);
                    return predicate;
                }
                    
                if (!string.IsNullOrEmpty(stringValue) && prop!.Name.Contains("Box"))
                {
                    predicate = predicate.And(x => EF.Property<object>(EF.Property<string>(x, columnName!), "Description").Equals(stringValue));
                    includeEntity = columnName!;
                    needsInclude = true;
                    return predicate;
                }

                if (!string.IsNullOrEmpty(stringValue) && !prop!.Name.Contains("From") && !prop.Name.Contains("To") && !prop!.Name.Contains("Box"))
                {
                    predicate = predicate.And(x => EF.Property<object>(x, columnName!).Equals(stringValue));
                    return predicate;
                }

            }

            if(value is int )
            {
                int intValue = Convert.ToInt32(value);

                if (intValue == 0)
                    return null!;

                predicate = predicate.And(x => EF.Property<int>(x, columnName) == intValue);
                
                return predicate;
            }

            if (value is double)
            {
                double doubleValue = Convert.ToDouble(value);

                if (doubleValue == 0.0)
                    return null!;

                predicate = predicate.And(x => EF.Property<double>(x, columnName) == doubleValue);

                return predicate;
            }

            return null!;
        }

    }
}
