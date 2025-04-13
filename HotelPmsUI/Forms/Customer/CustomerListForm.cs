using HotelPmsUI.ModelServices;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerListForm : Form
    {
        private readonly CustomerService customer;

        public DataGridView CustomerTable { get => customerTable; }

        public CustomerListForm(CustomerService customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        public BindingSource CustomerDataBindingSource { get => customerBindingSource; }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            previousPageButton.Enabled = false;
        }


        private void CustomerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customer.CustomerId = 0;

        }

        private void CustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currId = ((DataAccessLibrary.Models.Customer)CustomerDataBindingSource[e.RowIndex]).Id;
            customer.CustomerId = currId;
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            nextPageButton.Enabled = true;
            customer.CurrentPageDecrement = 1;

            customer.ViewData(CustomerDataBindingSource);
            customerTable.ClearSelection();
            customerTable.CurrentCell = null;

            if (customer.CurrentPage == 0)
                previousPageButton.Enabled = false; 
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            previousPageButton.Enabled = true;
            customer.CurrentPageIncrement = 1;

            customer.ViewData(CustomerDataBindingSource);

            if (customer.CurrentPage == customer.TotalPages)
                nextPageButton.Enabled = false;

            customerTable.ClearSelection();
            customerTable.CurrentCell = null;

        }
    }
}

