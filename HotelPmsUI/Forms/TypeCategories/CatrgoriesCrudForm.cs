using DataAccessLibrary.Models;
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
using System.Windows.Forms.VisualStyles;

namespace HotelPmsUI.Forms.TypeCategories
{
    public partial class CatrgoriesCrudForm : Form
    {
        private readonly CategoryService categoryService;
        private readonly DataAccessLibrary.Models.TypeCategory model;
        public CatrgoriesCrudForm(CategoryService categoryService, TypeCategory model)
        {
            InitializeComponent();
            this.categoryService = categoryService;
            typeCatgoryBindingSource.DataSource = categoryService.BindingSource;
            this.model = model;
        }

        public BindingSource? CategoryDataSource { get => typeCatgoryBindingSource; }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
                categoryService.SaveData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                categoryService.ViewData();
            }
            else
                return;
        }

        private bool CheckFields()
        {
            model.id = int.Parse(idTextBox.Text);
            model.Description = descriptionTextBox.Text;

            if (model.id <= 0)
            {
                MessageBox.Show("ID cannot be Zero");
                return false;
            }
            if (string.IsNullOrEmpty(model.Description))
            {

                MessageBox.Show("Description cannot be empty");
                return false;
            }

            return true;
        }
    }
}
