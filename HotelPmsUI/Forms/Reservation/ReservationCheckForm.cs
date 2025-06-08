using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
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

namespace HotelPmsUI.Forms.Reservation
{
    public partial class ReservationCheckForm : Form
    {
        private readonly DataAccessLibrary.Context.HpmsDbContext context;
        private readonly ModelServices.ReservationService service;

        public ReservationCheckForm(DataAccessLibrary.Context.HpmsDbContext context, ModelServices.ReservationService service)
        {
            InitializeComponent();
            this.context = context;
            this.service = service;

            customerCombobox.SelectedIndex = -1;
            reservationBindingSource.DataSource = service.ReservationSource;
            centerPanel.Hide();
            bottomPanel.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            centerPanel.Enabled = true;

            centerPanel.Show();
            service.SearchCheckInOut(reservationDateTimePicker, customerCombobox);
            reservationDataGridView.CurrentCell = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            service.GetCheckInOut(checkInCheckBox, checkOutCheckBox);
            service.SaveReservation();
            Reset();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Reset();
            }
            else
                return;
        }

        public void ShowCheckInOutForm(Control mainPanel)
        {
            mainPanel.Controls.Clear();

            this.TopLevel = false;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(this);
            this.Show();

        }

        private void customerCombobox_DropDown(object sender, EventArgs e)
        {
            service.SetCustomerComboBox(customerCombobox);
        }

        private void reservationDataGridView_DoubleClick(object sender, EventArgs e)
        {
            bottomPanel.Show();
            centerPanel.Enabled = false;

            service.SetRoomNumber<DataAccessLibrary.Models.Reservation>(reservationBindingSource);
            roomPriceText.Text = 20.ToString();
            var roomPrice = Convert.ToDouble(roomPriceText.Text);
            service.SetTotalPrice(roomPrice);
            totalPriceText.Text = service.TotalPrice.ToString();
        }

        private void reservationDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            service.SetIndex(e.RowIndex);
        }

        private void Reset()
        {
            reservationDateTimePicker.Value = DateTime.Now;
            customerCombobox.SelectedIndex = -1;
            roomPriceText.Clear();
            totalPriceText.Clear();
            reservationBindingSource.Clear();

            checkInCheckBox.Checked = false;
            checkOutCheckBox.Checked = false;

            centerPanel.Hide();
            bottomPanel.Hide();

        }

        private void checkInCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInCheckBox.Checked)
                checkOutCheckBox.Enabled = false;
            else
                checkOutCheckBox.Enabled = true;
        }

        private void checkOutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOutCheckBox.Checked)
                checkInCheckBox.Enabled = false;
            else
                checkInCheckBox.Enabled = true;
        }

        
    }
}
