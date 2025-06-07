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

        #region Properties for filtering
        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FirstName")]
        public string? Firstname { get => firstNameText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FirstName")]
        public string? FirstnameFrom { get => firstnameFromText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FirstName")]
        public string? FirstnameTo { get => firstnameToText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "LastName")]
        public string? Lastname { get => lastnameText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "LastName")]
        public string? LastnameFrom { get => lastnameFromText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "LastName")]
        public string? LastnameTo { get => lastnameToText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "Tin")]
        public string? Tin { get => tinText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "Tin")]
        public string? TinFrom { get => tinFromText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "Tin")]
        public string? TinTo { get => tinToText.Text; }
        #endregion

        private readonly ModelServices.CustomerService customerService;

        private List<TextBox> textBoxes = new();

        public CustomerFilterForm(ModelServices.CustomerService customerService)
        {
            InitializeComponent();
            firstnameFromText.Enabled = false;
            firstnameToText.Enabled = false;

            lastnameFromText.Enabled = false;
            lastnameToText.Enabled = false;

            tinFromText.Enabled = false;
            tinToText.Enabled = false;

            this.customerService = customerService;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            LoadTextBoxes();
            foreach (var box in textBoxes)
                box.Clear();

            firstNameRangeCheckBox.Checked = false;
            lastnameRangeCheckBox.Checked = false;
            tinRangeCheckBox.Checked = false;
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
            if (firstnameFromText.Text.Contains('*') || firstnameToText.Text.Contains('*'))
            {
                MessageBox.Show("You can't use '*' in range search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customerService.Filter();
        }

        private void firstNameRangeButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesAccess(firstNameRangeCheckBox, firstNameText, firstnameFromText, firstnameToText);
        }

        private void lastnameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesAccess(lastnameRangeCheckBox, lastnameText, lastnameFromText, lastnameToText);
        }

        private void tinRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesAccess(tinRangeCheckBox, tinText, tinFromText, tinToText);
        }

        private void ChangeTextBoxesAccess(CheckBox range,TextBox box,TextBox from, TextBox to)
        {
            if (range.Checked)
            {
                box.Enabled = false;
                from.Enabled = true;
                to.Enabled = true;
            }
            else
            {
                box.Enabled = true;
                from.Enabled = false;
                to.Enabled = false;
            }
        }

        private void LoadTextBoxes()
        {
            textBoxes.Add(firstNameText);
            textBoxes.Add(firstnameFromText);
            textBoxes.Add(firstnameToText);

            textBoxes.Add(lastnameText);
            textBoxes.Add(lastnameFromText);
            textBoxes.Add(lastnameToText);

            textBoxes.Add(tinText);
            textBoxes.Add(tinFromText);
            textBoxes.Add(tinToText);
        }
    }
}
