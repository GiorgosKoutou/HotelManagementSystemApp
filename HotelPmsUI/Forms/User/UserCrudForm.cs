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
    public partial class UserCrudForm : Form
    {

        private readonly ModelServices.UserService userService;
        public UserCrudForm(UserService userService)
        {

            var userDesc = Program.ServiceProvider!.GetRequiredService<StartupData>();
            userDesc.LoadUserDesc();

            this.userService = userService;

            InitializeComponent();

            userBindingSource.DataSource = userService.BindingSource;

            userRoleBindingSource.DataSource = userDesc.UserDescList;
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            userService.SaveData();
            if (userService.IsNew)
                userRoleBox.SelectedIndex = -1;
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
