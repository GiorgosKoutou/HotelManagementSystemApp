using HotelPmsUI.Forms.Customer;
using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace HotelPmsUI.Forms
{
    public partial class MainForm : Form
    {

        private ModelServices.IService? currentModule;
        private bool isClicked = false;
        public Control? NewButton { get => newButton; }
        public Control? EditButton { get => editButton; }
        public MainForm()
        {
            var user = Program.ServiceProvider?.GetRequiredService<UserLogin>();

            InitializeComponent();
            welcomeLabel.Text = $"Welcome: {user!.FullName}";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonPanel.Visible = false;
            userCategoryButton.Visible = false;
            roomCategoriesButton.Visible = false;
            var seed = Program.ServiceProvider?.GetRequiredService<DataSeed>();

        }


        private void customerButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.CustomerService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

       
        private void categoryButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;


            currentModule = Program.ServiceProvider?.GetService<ModelServices.CategoryService>();

            currentModule?.SetPanel(centerPanel);
            currentModule!.CategoryType = 3;

            currentModule?.ViewData();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.RoomService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.UserService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void userCategoryButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;


            currentModule = Program.ServiceProvider?.GetService<ModelServices.CategoryService>();

            currentModule?.SetPanel(centerPanel);
            currentModule!.CategoryType = 3;

            currentModule?.ViewData();
        }

        private void roomCategoriesButton_Click(object sender, EventArgs e)
        {

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;


            currentModule = Program.ServiceProvider?.GetService<ModelServices.CategoryService>();

            currentModule?.SetPanel(centerPanel);
            currentModule!.CategoryType = 2;

            currentModule?.ViewData();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            editButton.Enabled = false;
            currentModule?.NewData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            newButton.Enabled = false;
            currentModule?.EditData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete the data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                currentModule?.DeleteData();
            }
            else
            {
                return;
            }

        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {

            if (!isClicked)
            {
                userCategoryButton.Visible = true;
                roomCategoriesButton.Visible = true;
                menuPanel.Width = 246;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isClicked = true;
            }
            else
            {
                userCategoryButton.Visible = false;
                roomCategoriesButton.Visible = false;
                menuPanel.Width = 207;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isClicked = false;
            }
        }

       
    }
}

