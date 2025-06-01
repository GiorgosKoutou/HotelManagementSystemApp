using DataAccessLibrary.Models;
using HotelPmsUI.ModelServices;
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
    public partial class UserListForm : Form
    {
        private readonly UserService userService;
        public UserListForm(UserService userService)
        {
            InitializeComponent();
            buttonPanel.Visible = false;

            this.userService = userService;

            userBindingSource.DataSource = userService.BindingSource;
        }

        private void userDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            userService.SetIndex(e.RowIndex);
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            if(userService.TotalRecords > 30)
                buttonPanel.Visible = true;

            if (userService.CurrentPage == 1)
                previousPageButton.Enabled = false;

            if (userService.CurrentPage == userService.TotalPages)
                nextPageButton.Enabled = false;
        }
    }
}
