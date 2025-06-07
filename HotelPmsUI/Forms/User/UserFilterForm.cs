using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.User
{
    public partial class UserFilterForm : Form
    {

        #region Properties for filtering
        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "UserName")]
        public string? Username { get => userNameText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "FullName")]
        public string? Fullname { get => fullNameText.Text; }

        [DataAccessLibrary.AttributeMarkerClasses.ColumnNames(Name = "UserRole")]
        public string? UserRoleBox { get => userRoleComboBox.Text; }
        #endregion

        private readonly ModelServices.UserService userService;
        public UserFilterForm(ModelServices.UserService userService)
        {
            InitializeComponent();
            this.userService = userService;

            var roleData = Program.ServiceProvider?.GetRequiredService<StartupData>();
            roleData?.LoadUserDesc();
            userRoleComboBox.DataSource = roleData!.UserDescList;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            userService.Filter();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userNameText.Clear();
            fullNameText.Clear();
            userRoleComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                userService.ViewData();
            }
            else
                return;
        }
    }
}
