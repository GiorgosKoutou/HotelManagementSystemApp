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

namespace HotelPmsUI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ModelServices.UserService userService;

        private readonly DataAccessLibrary.Context.HpmsDbContext context;

        private readonly UserLogin login;

        public UserLogin LoginInfo { get => login; }

        public LoginForm(ModelServices.UserService userService, DataAccessLibrary.Context.HpmsDbContext context, UserLogin login)
        {
            InitializeComponent();
            this.userService = userService;
            this.context = context;
            this.login = login;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (login.ChechLoginInfo(usernameText, passwordText))
            {
                this.Close();
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (login.ChechLoginInfo(usernameText, passwordText))
                {
                    this.Close();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var mainForm = Program.ServiceProvider?.GetRequiredService<MainForm>();

            mainForm?.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameText.Text = string.Empty;
            passwordText.Text = string.Empty;
        }
    }
}
