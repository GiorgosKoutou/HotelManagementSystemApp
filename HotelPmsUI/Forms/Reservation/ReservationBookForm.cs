using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelPmsUI.Forms.Reservation
{
    public partial class ReservationBookForm : Form
    {
        private readonly DataAccessLibrary.Context.HpmsDbContext context;
        private readonly ModelServices.ReservationService service;
        private int index = -1;
        public ReservationBookForm(DataAccessLibrary.Context.HpmsDbContext context, ModelServices.ReservationService service)
        {
            InitializeComponent();
            this.service = service;
            this.context = context;
            reservationBindingSource.DataSource = service.ReservationSource;
            roomBindingSource.DataSource = service.RoomSource;

            reservationBindingSource.AddNew();

            customerInfoText.Hide();
            centerPanel.Hide();
            bottomPanel.Hide();
            customerInfoText.Location = customerInfoComboBox.Location;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            centerPanel.Enabled = true;
            centerPanel.Show();
            bottomPanel.Show();
            service.SearchReservationForBook(reservationFromDateTimePicker, reservationToDateTimePicker, peopleNumber);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            service.CustomerInfo = customerInfoText.Text;
            service.GetCustomerCheckBox(newCustomerCheckBox);
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

        public void ShowBookForm(Control panel)
        {
            panel.Controls.Clear();

            this.TopLevel = false;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            panel.Controls.Add(this);
            this.Show();

        }

        private void customerInfoComboBox_DropDown(object sender, EventArgs e)
        {
            service.SetCustomerComboBox(customerInfoComboBox);
        }

        private void roomDataGridView_DoubleClick(object sender, EventArgs e)
        {
            centerPanel.Enabled = false;
            service.SetRoomNumber<DataAccessLibrary.Models.Room>(roomBindingSource);
            roomText.Text = service.RoomNumber;
        }

        private void roomDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            service.SetIndex(e.RowIndex);
        }



        private void newCustomerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (newCustomerCheckBox.Checked)
            {
                customerInfoText.Show();
                customerInfoComboBox.Hide();
            }
            else
            {
                customerInfoComboBox.Show();
                customerInfoText.Hide();
            }
        }

        private void Reset()
        {
            reservationFromDateTimePicker.Value = DateTime.Now;
            reservationToDateTimePicker.Value = DateTime.Now;
            peopleNumber.Value = 0;
            customerInfoComboBox.SelectedIndex = -1;
            roomText.Clear();
            customerInfoText.Clear();
            roomBindingSource.Clear();

            customerInfoComboBox.Show();
            customerInfoText.Hide();
            newCustomerCheckBox.Checked = false;
            reservationBindingSource.AddNew();
            centerPanel.Hide();
            bottomPanel.Hide();

        }
    }
}
