using DataAccessLibrary.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.PriceList
{
    public partial class PriceListCrudForm : Form
    {
        private readonly ModelServices.PriceListService service;

        public PriceListCrudForm(ModelServices.PriceListService service)
        {
            InitializeComponent();
            this.service = service;

            priceListBindingSource.DataSource = service.BindingSource;
            priceListDetailBindingSource.DataSource = service.DetailsSource;
            //service.DetailsList = (List<DataAccessLibrary.Models.PriceListDetail>)priceListDetailBindingSource.List;

            var periods = service.Context.Period.ToList();
            periodComboBox.DataSource = periods;

            var roomTypes = Program.ServiceProvider?.GetRequiredService<StartupData>();

            roomTypes!.LoadRoomDesc();
            typeCategoryBindingSource.DataSource = roomTypes.RoomDescList;

        }

        private void priceListDetailDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            service.SetDetailsIndex(e.RowIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            service.SaveData();
            if (service.IsNew)
            {
                periodComboBox.SelectedIndex = -1;
                priceListDetailBindingSource.Clear();
            }
            
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

        private void addRowButton_Click(object sender, EventArgs e)
        {
            priceListDetailDataGridView.AllowUserToAddRows = true;
        }

        private void removeRowButton_Click(object sender, EventArgs e)
        {
            service.DeleteDetailsData();
            priceListDetailBindingSource.RemoveCurrent();
        }
    }
}

