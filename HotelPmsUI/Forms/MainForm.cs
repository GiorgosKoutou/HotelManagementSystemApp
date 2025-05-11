using HotelPmsUI.Forms.Customer;
using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace HotelPmsUI.Forms
{
    public partial class MainForm : Form
    {

        private ModelServices.IService? currentModule;
        public Control? NewButton { get => newButton; }
        public Control? EditButton { get => editButton; }
        public MainForm()
        {
            InitializeComponent();

        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.CustomerService>();

            currentModule?.SetPanel(mainPanel);

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonPanel.Visible = false;
            var seed = Program.ServiceProvider.GetRequiredService<DataSeed>();

        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;


            currentModule = Program.ServiceProvider.GetService<ModelServices.CategoryService>();

            currentModule.SetPanel(mainPanel);
            currentModule.CategoryType = 3;

            currentModule?.ViewData();
        }

        private void roomCategoriesButton_Click(object sender, EventArgs e)
        {

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;


            currentModule = Program.ServiceProvider.GetService<ModelServices.CategoryService>();

            currentModule.SetPanel(mainPanel);
            currentModule.CategoryType = 2;

            currentModule?.ViewData();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.RoomService>();

            currentModule?.SetPanel(mainPanel);

            currentModule?.ViewData();
        }
    }
}

