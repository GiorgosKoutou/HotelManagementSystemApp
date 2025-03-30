using HotelPmsUI.ModelServices;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerListForm : Form
    {
        private readonly CustomerService customerService;

        public CustomerListForm(CustomerService customer)
        {
            InitializeComponent();
            this.customerService = customer;
        }

        public BindingSource CustomerDataBindingSource { get => customerBindingSource; }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            previousPageButton.Enabled = false;
        }


        private void CustomerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerService.CustomerId = 0;

        }

        private void CustomerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currId = ((DataAccessLibrary.Models.Customer)CustomerDataBindingSource[e.RowIndex]).Id;
            customerService.CustomerId = currId;
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            customerService.CurrentPageDecrement = 1;
            customerService.ViewData(CustomerDataBindingSource);
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            previousPageButton.Enabled = true;

            customerService.CurrentPageIncrement = 1;
            customerService.ViewData(CustomerDataBindingSource);
        }
    }
}

