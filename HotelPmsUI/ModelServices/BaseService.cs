using HotelPmsUI.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace HotelPmsUI.ModelServices
{
    public class BaseService<TModel, TFormCrud, TFormList>(DataAccessLibrary.Context.HpmsDbContext context) : IService
            where TModel : class where TFormCrud : Form where TFormList : Form
    {
        internal Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction? transaction;

        private int currentPage = 0;
        private int skippedRecords;
        private int recordsPerPage = 30;
        private int totalRecords = context.Set<TModel>().Count();
        private int totalPages = 0;
        private int currentIndex = -1;
        internal bool isNew = false;
        private int categoryType;
        internal bool isAdded = false;

        internal TModel? initialRecord;
        internal IQueryable<TModel>? records;

        private TFormCrud? formCrud;
        private TFormList? formList;
        private Forms.MainForm? mainForm = Program.ServiceProvider?.GetRequiredService<Forms.MainForm>();
        private Control? mainPanel;

        private BindingSource? bindingSource = new();


        public int CurrentPage { get => currentPage; }
        public int CurrentPageIncrement { set => currentPage += value; }
        public int CurrentPageDecrement { set => currentPage -= value; }
        public int RecordsPerPage { get => recordsPerPage; }
        public int TotalRecords { get => totalRecords; }
        public int TotalPages { get => totalPages; }

        public int CurrentIndex { get => currentIndex; }

        public TFormList? FormList { get; set; }
        public BindingSource? BindingSource { get => bindingSource; }
        public int CategoryType { get => categoryType; set => categoryType = value; }

        public virtual void ViewData()
        {
            mainForm.NewButton.Enabled = true;
            mainForm.EditButton.Enabled = true;

            CalculatePages();
            skippedRecords = currentPage * recordsPerPage;

            records ??= context.Set<TModel>();

            var entity = records.Skip(skippedRecords).Take(recordsPerPage).ToList();
            bindingSource.DataSource = entity;

            ShowListForm();
        }

        public virtual void SaveData()
        {
            transaction = context.Database.BeginTransaction();
            var currentRecord = (TModel)bindingSource.Current;

            if (isNew)
            {
                context.Add(currentRecord);
                context.SaveChanges();
                bindingSource.DataSource = initialRecord;
                isNew = false;
            }
            else
            {
                context.Update(currentRecord);
                context.SaveChanges();
            }

        }

        public virtual void NewData()
        {
            isNew = true;
            var newRecord = bindingSource.AddNew();
            initialRecord = ((TModel)newRecord).CopyData();
            bindingSource.DataSource = newRecord;

            ShowCrudForm();
        }

        public virtual void EditData()
        {
            isNew = false;
            var entity = (TModel)bindingSource[currentIndex];
            bindingSource.DataSource = entity;

            ShowCrudForm();
        }


        public virtual void DeleteData()
        {
            var entity = (TModel)bindingSource[currentIndex];
            context.Set<TModel>().Remove(entity);
            context.SaveChanges();
            ViewData();


        }

        private void CalculatePages()
        {
            totalPages = totalRecords / recordsPerPage;
        }

        public virtual void ShowCrudForm()
        {
            formList?.Close();
            mainPanel?.Controls.Clear();

            formCrud = Program.ServiceProvider?.GetRequiredService<TFormCrud>();
            //var formSource = Program.ServiceProvider?.GetRequiredService<Forms.MainForm>();
            mainForm.CenterForm(formCrud);
            formCrud.ShowDialog();

            //formCrud.TopLevel = false;
            //formCrud.TopMost = false;
            //formCrud.FormBorderStyle = FormBorderStyle.None;
            //formCrud.Dock = DockStyle.Fill;

            //mainPanel?.Controls.Add(formCrud);
            //formCrud.Show();
        }

        public void ShowListForm()
        {
            formCrud?.Close();
            mainPanel?.Controls.Clear();

            formList = Program.ServiceProvider?.GetRequiredService<TFormList>();

            formList.TopLevel = false;
            formList.TopMost = false;
            formList.FormBorderStyle = FormBorderStyle.None;
            formList.Dock = DockStyle.Fill;

            mainPanel?.Controls.Add(formList);
            formList.Show();
        }

        public void SetIndex(int index)
        {
            currentIndex = index;
        }

        public void SetBindingSource(BindingSource gridSource, BindingSource crudSource)
        {

            gridSource.DataSource = bindingSource;
            crudSource.DataSource = bindingSource;
        }

        public void SetPanel(Control panel)
        {
            mainPanel = panel;
        }

        public void SetForms(Form crudForm, Form listForm)
        {
            formCrud = (TFormCrud?)crudForm;
            formList = (TFormList?)listForm;
        }

        internal void SetRecords<T>(IQueryable<T> records)
        {
            this.records = (IQueryable<TModel>?)records;
        }
    }
}
