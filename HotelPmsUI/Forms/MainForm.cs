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

        private bool isCategoriesClicked = false;
        private bool isReservationsClicked = false;
        public Control? NewButton { get => newButton; }
        public Control? EditButton { get => editButton; }
        public Control? UserButton { get => userButton; }
        public Label WelcomeLabel { get => welcomeLabel; }
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
            bookButton.Visible = false;
            checkInOutButton.Visible = false;

        }


        private void customerButton_Click(object sender, EventArgs e)
        {
            isCategoriesClicked = true;
            isReservationsClicked = true;

            CategoriesClicked();
            ReservationsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;
            searchButton.Visible = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.CustomerService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            isCategoriesClicked = true;
            isReservationsClicked = true;

            CategoriesClicked();
            ReservationsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;
            searchButton.Visible = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.RoomService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            isReservationsClicked = true;
            isCategoriesClicked = true;

            CategoriesClicked();
            ReservationsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;
            searchButton.Visible = true;

            currentModule = Program.ServiceProvider?.GetService<ModelServices.UserService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            isCategoriesClicked = true;
            isReservationsClicked = true;

            CategoriesClicked();
            ReservationsClicked();

            buttonPanel.Visible = true;

            editButton.Enabled = true;
            newButton.Enabled = true;
            searchButton.Visible = true;

            currentModule = Program.ServiceProvider?.GetRequiredService<ModelServices.StaffService>();

            currentModule?.SetPanel(centerPanel);

            currentModule?.ViewData();

        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {
            isCategoriesClicked = true;
            CategoriesClicked();
            ReservationsClicked();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            var reservation = Program.ServiceProvider?.GetRequiredService<Forms.Reservation.ReservationBookForm>();

            reservation!.ShowBookForm(centerPanel);
        }

        private void checkInOutButton_Click(object sender, EventArgs e)
        {
            var reservation = Program.ServiceProvider?.GetRequiredService<Forms.Reservation.ReservationCheckForm>();

            reservation!.ShowCheckInOutForm(centerPanel);
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            isReservationsClicked = true;
            ReservationsClicked();
            CategoriesClicked();

        }

        private void userCategoryButton_Click(object sender, EventArgs e)
        {
            searchButton.Visible = false;

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
            searchButton.Visible = false;

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
            searchButton.Visible = false;

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

        private void CategoriesClicked()
        {
            if (!isCategoriesClicked)
            {
                userCategoryButton.Visible = true;
                roomCategoriesButton.Visible = true;
                specialtyCategoriesButton.Visible = true;
                menuPanel.Width = 276;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isCategoriesClicked = true;
            }
            else
            {
                userCategoryButton.Visible = false;
                roomCategoriesButton.Visible = false;
                specialtyCategoriesButton.Visible = false;
                menuPanel.Width = 214;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isCategoriesClicked = false;
            }
        }

        private void ReservationsClicked()
        {
            if (!isReservationsClicked)
            {
                bookButton.Visible = true;
                checkInOutButton.Visible = true;
                menuPanel.Width = 222;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isReservationsClicked = true;
            }
            else
            {
                bookButton.Visible = false;
                checkInOutButton.Visible = false;
                menuPanel.Width = 213;
                centerPanel.Controls.Clear();
                buttonPanel.Visible = false;
                isReservationsClicked = false;
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

