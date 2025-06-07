using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.Staff
{
    public partial class StaffFilterForm : Form
    { 
        #region Properties for filtering
        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FirstName")]
        public string? Firstname { get => firstnameText.Text; }

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

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "Specialty")]
        public string? SpecialtyBox { get => specialtyComboBox.Text; }
        #endregion

        private readonly ModelServices.StaffService staffService;

        private List<TextBox> textBoxes = new();
        public StaffFilterForm(ModelServices.StaffService staffService)
        {
            InitializeComponent();

            firstnameFromText.Enabled = false;
            firstnameToText.Enabled = false;

            lastnameFromText.Enabled = false;
            lastnameToText.Enabled = false;

            this.staffService = staffService;
            var specialtyData = Program.ServiceProvider?.GetRequiredService<StartupData>();

            specialtyData?.LoadStaffDesc();

            specialtyComboBox.DataSource = specialtyData!.SpecialtyDesc;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (firstnameFromText.Text.Contains('*') || firstnameToText.Text.Contains('*') 
                || lastnameFromText.Text.Contains('*') || lastnameToText.Text.Contains('*'))
            {
                MessageBox.Show("You can't use '*' in range search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            staffService.Filter();
        }

        private void firstnameRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesAccess(firstnameRangeCheckBox, firstnameText, firstnameFromText, firstnameToText);
        }

        private void lastnameRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesAccess(lastnameRangeCheckBox, lastnameText, lastnameFromText, lastnameToText);
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            LoadTextBoxes();

            foreach (var box in textBoxes)
            {
                box.Clear();
            }

            firstnameRangeCheckBox.Checked = false;
            lastnameRangeCheckBox.Checked = false;
            specialtyComboBox.SelectedIndex = 0;
        }

        private void ChangeTextBoxesAccess(CheckBox range, TextBox box, TextBox from, TextBox to)
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
            textBoxes.Add(firstnameText);
            textBoxes.Add(firstnameFromText);
            textBoxes.Add(firstnameToText);

            textBoxes.Add(lastnameText);
            textBoxes.Add(lastnameFromText);
            textBoxes.Add(lastnameToText);
        }
    }
}
