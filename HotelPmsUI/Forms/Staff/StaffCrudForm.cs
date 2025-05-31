using DataAccessLibrary.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.Staff
{
    public partial class StaffCrudForm : Form
    {
        private readonly ModelServices.StaffService staffService;
        public StaffCrudForm(ModelServices.StaffService staffService)
        {
            InitializeComponent();
            this.staffService = staffService;
            staffBindingSource.DataSource = staffService.BindingSource;
        }

        private void StaffCrudForm_Load(object sender, EventArgs e)
        {
            var staffDesc = Program.ServiceProvider?.GetRequiredService<StartupData>();
            staffDesc!.LoadStaffDesc();

            typeCategoryBindingSource.DataSource = staffDesc.SpecialtyDesc;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            staffService.SaveData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                staffService.ViewData();
            }
            else
                return;
        }
    }
}
