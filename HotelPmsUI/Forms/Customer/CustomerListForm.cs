using HotelPmsUI.ModelServices;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerListForm : Form
    {
        private readonly CustomerService customer;

        public CustomerListForm(CustomerService customer)
        {
            InitializeComponent();
            this.customer = customer;
            customerBindingSource.DataSource = customer.BindingSource;
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            if(customer.TotalRecords > 30)
            {
                buttonpanel.Visible = true;
            }

            if (customer.CurrentPage == 1)
                previousPageButton.Enabled = false;

            if (customer.CurrentPage == customer.TotalPages)
                nextPageButton.Enabled = false;

        }


        private void previousPageButton_Click(object sender, EventArgs e)
        {
            customer.CheckPage(previousPageButton, nextPageButton);
            customer.CurrentPageDecrement = 1;
            customer.StartPointDecrement = 1;

            customer.ViewData();

        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            customer.CheckPage(previousPageButton, nextPageButton);
            customer.CurrentPageIncrement = 1;
            customer.StartPointIncrement = 1;

            customer.ViewData();


        }

        private void customerDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            customer.SetIndex(e.RowIndex);
        }
    }
}

