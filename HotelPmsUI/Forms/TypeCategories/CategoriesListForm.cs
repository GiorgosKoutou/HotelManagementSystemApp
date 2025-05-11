using HotelPmsUI.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.TypeCategories
{
    public partial class CategoriesListForm : Form
    {

        private readonly CategoryService categoryService;
        public CategoriesListForm(CategoryService categoryService)
        {
            InitializeComponent();
            this.categoryService = categoryService;
            typeCatgoryBindingSource.DataSource = categoryService.BindingSource;
        }

        public BindingSource TypeCategorySource { get => typeCatgoryBindingSource; }

        private void categoriesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            categoryService.SetIndex(e.RowIndex);
        }
    }
}
