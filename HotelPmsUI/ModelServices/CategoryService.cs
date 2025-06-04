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
    public class CategoryService : BaseService<DataAccessLibrary.Models.TypeCategory, 
                                Forms.TypeCategories.CatrgoriesCrudForm, Forms.TypeCategories.CategoriesListForm, Form>
    {
        public CategoryService(HpmsDbContext context) : base(context) {

            var records = context.Set<DataAccessLibrary.Models.TypeCategory>().Where(tc => tc.Type == CategoryType);
            SetRecords(records);
        }

        public override void SaveData()
        {
            ((TypeCategory)BindingSource!.Current).Type = CategoryType;

            base.SaveData();
           
        }
    }
}
