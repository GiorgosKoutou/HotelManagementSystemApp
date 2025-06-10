using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.PriceList
{
    public partial class PriceListListForm : Form
    {
        private readonly ModelServices.PriceListService service;
        public PriceListListForm(ModelServices.PriceListService service)
        {
            InitializeComponent();
            this.service = service;

            priceListBindingSource.DataSource = service.BindingSource;
        }

        private void priceListDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            service.SetIndex(e.RowIndex);
        }
    }
}
