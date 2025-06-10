using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.Period
{
    public partial class PeriodCrudForm : Form
    {
        private readonly ModelServices.PeriodService service;
        public PeriodCrudForm(ModelServices.PeriodService service)
        {
            InitializeComponent();
            this.service = service;

            periodBindingSource.DataSource = service.BindingSource;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            service.SaveData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                service.ViewData();
            }
            else
                return;
        }

        
    }
}
