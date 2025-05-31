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
    public partial class StaffListForm : Form
    {
        private readonly ModelServices.StaffService staffService;
        public StaffListForm(ModelServices.StaffService staffService)
        {
            InitializeComponent();

            this.staffService = staffService;

            staffBindingSource.DataSource = staffService.BindingSource;
        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            if (staffService.TotalRecords > 30)
                buttonPanel.Visible = true;

            if (staffService.CurrentPage == 1)
                previousButton.Enabled = false;

            if (staffService.CurrentPage == staffService.TotalPages)
                nextButton.Enabled = false;
        }

        private void staffDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            staffService.SetIndex(e.RowIndex);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            staffService.CheckPage(previousButton,nextButton);
            staffService.CurrentPageDecrement = 1;
            staffService.StartPointDecrement = 1;

            staffService.ViewData();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            staffService.CheckPage(previousButton,nextButton);
            staffService.CurrentPageIncrement = 1;
            staffService.StartPointIncrement = 1;

            staffService.ViewData();

        }
    }
}
