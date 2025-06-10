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

        private readonly MainForm mainForm;

        public UserLogin LoginInfo { get => login; }

        public LoginForm(ModelServices.UserService userService, DataAccessLibrary.Context.HpmsDbContext context, UserLogin login, MainForm mainForm)
        {
            InitializeComponent();
            this.userService = userService;
            this.context = context;
            this.login = login;
            this.mainForm = mainForm;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (login.CheckLoginInfo(usernameText, passwordText))
            {
                this.Close();

                if (!login.Description!.Equals("Administrator"))
                    mainForm.UserButton!.Visible = false;

                mainForm.WelcomeLabel.Text = $"Welcome: {login.FullName}";
                mainForm.BackroundPanel.Visible = true;
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (login.CheckLoginInfo(usernameText, passwordText))
                {
                    this.Close();

                    if (!login.Description!.Equals("Administrator"))
                        mainForm.UserButton!.Visible = false;

                    mainForm.WelcomeLabel.Text = $"Welcome: {login.FullName}";
                    mainForm.BackroundPanel.Visible = true;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            mainForm?.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameText.Text = string.Empty;
            passwordText.Text = string.Empty;
        }
    }
}
