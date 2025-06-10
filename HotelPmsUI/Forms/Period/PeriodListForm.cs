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
    public partial class PeriodListForm : Form
    {
        private readonly ModelServices.PeriodService service;
        public PeriodListForm(ModelServices.PeriodService service)
        {
            InitializeComponent();
            this.service = service;

            periodBindingSource.DataSource = service.BindingSource;
        }

        private void periodDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            service.SetIndex(e.RowIndex);
        }
    }
}
