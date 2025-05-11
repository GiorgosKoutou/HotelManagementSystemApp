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

        public BindingSource? CustomerDataBindingSource { get => customerBindingSource; }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            
            if (customer.CurrentPage == 0)
                previousPageButton.Enabled = false;

            if (customer.CurrentPage == customer.TotalPages)
                nextPageButton.Enabled = false;

        }


        private void previousPageButton_Click(object sender, EventArgs e)
        {
            nextPageButton.Enabled = true;
            customer.CurrentPageDecrement = 1;

            customer.ViewData();

            customerTable.ClearSelection();
            customerTable.CurrentCell = null;
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            previousPageButton.Enabled = true;
            customer.CurrentPageIncrement = 1;

            customer.ViewData();

            customerTable.ClearSelection();
            customerTable.CurrentCell = null;

        }

        private void customerTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            customer.SetIndex(e.RowIndex);
        }

    }
}

