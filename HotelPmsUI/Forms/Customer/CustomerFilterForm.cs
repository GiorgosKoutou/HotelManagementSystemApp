using DataAccessLibrary.Models;
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

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerFilterForm : Form
    {
        private readonly ModelServices.CustomerService customerService;

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FirstName")]
        public string Firstname { get => firstNameText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FirstName")]
        public string FirstnameFrom { get => firstnameFromText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FirstName")]
        public string FirstnameTo { get => firstnameToText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "LastName")]
        public string Lastname { get => lastnameText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "Tin")]
        public string Tin { get => tinText.Text; }
        public CustomerFilterForm(ModelServices.CustomerService customerService)
        {
            InitializeComponent();
            firstnameFromText.Enabled = false;
            firstnameToText.Enabled = false;

            this.customerService = customerService;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstnameFromText.Clear();
            firstnameToText.Clear();
            lastnameText.Clear();
            tinText.Clear();
            firstNameRangeButton.Checked = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                customerService.ViewData();
            }
            else
                return;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(firstnameFromText.Text.Contains('*') || firstnameToText.Text.Contains('*'))
            {
                MessageBox.Show("You can't use '*' in range search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            

            customerService.Filter();
        }

        private void firstNameRangeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (firstNameRangeButton.Checked)
            {
                firstNameText.Enabled = false;
                firstnameFromText.Enabled = true;
                firstnameToText.Enabled = true;
            }
            else
            {
                firstNameText.Enabled = true;
                firstnameFromText.Enabled = false;
                firstnameToText.Enabled = false;
            }
        }
    }
}
