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
            this.userService = userService;

            userBindingSource.DataSource = userService.BindingSource;
        }
    }
}
