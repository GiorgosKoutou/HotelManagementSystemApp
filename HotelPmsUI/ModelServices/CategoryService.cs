using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.ModelServices
{
    public class CategoryService : BaseService<DataAccessLibrary.Models.TypeCatgory, Forms.TypeCategories.CatrgoriesCrudForm, Forms.TypeCategories.CategoriesListForm>
    {
        public CategoryService(HpmsDbContext context) : base(context) {

            var records = context.Set<DataAccessLibrary.Models.TypeCatgory>().Where(tc => tc.Type == CategoryType);
            SetRecords(records);
        }

        public override void SaveData()
        {
            ((TypeCatgory)BindingSource.Current).Type = CategoryType;

            try
            {
                if (isNew)
                    MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Category Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.SaveData();
                transaction?.Commit();
            }
            catch (DbException ex) {
                
                string message = ex.Message;
                
                MessageBox.Show($"Error: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
