using HotelPmsUI.Extensions;
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
        public Control? UserButton { get => userButton; }
        public Label WelcomeLabel { get => welcomeLabel;}
        public MainForm()
        {
            InitializeComponent();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            var seed = Program.ServiceProvider?.GetRequiredService<DataSeed>();

            var login = Program.ServiceProvider?.GetRequiredService<LoginForm>();
            this.CenterForm(login!);
            login!.ShowDialog();



            buttonPanel.Visible = false;
            userCategoryButton.Visible = false;
            roomCategoriesButton.Visible = false;
            specialtyCategoriesButton.Visible = false;

        }


        private void customerButton_Click(object sender, EventArgs e)
        {
            isClicked = true;
            IsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.CustomerService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            isClicked = true;
            IsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.RoomService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            isClicked = true;
            IsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.UserService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            isClicked = true;
            IsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetRequiredService<ModelServices.StaffService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();

        }

        private void categoryButton_Click(object sender, EventArgs e)
        {

            IsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;


            currentModule = Program.ServiceProvider?.GetService<ModelServices.CategoryService>();

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

        private void specialtyCategoriesButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;


            currentModule = Program.ServiceProvider?.GetService<ModelServices.CategoryService>();

            currentModule?.SetPanel(centerPanel);
            currentModule!.CategoryType = 1;

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
                currentModule?.ViewData();
            }
            else
            {
                return;
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            currentModule?.ShowFilterForm();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            IsClicked();
        }

        private void IsClicked()
        {
            if (!isClicked)
            {
                userCategoryButton.Visible = true;
                roomCategoriesButton.Visible = true;
                specialtyCategoriesButton.Visible = true;
                menuPanel.Width = 285;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isClicked = true;
            }
            else
            {
                userCategoryButton.Visible = false;
                roomCategoriesButton.Visible = false;
                specialtyCategoriesButton.Visible = false;
                menuPanel.Width = 214;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isClicked = false;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                this.Hide();
                var login = Program.ServiceProvider?.GetRequiredService<LoginForm>();
                this.CenterForm(login!);
                login!.ShowDialog();
            }
        }

        
    }
}

