using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;

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

        public BindingSource CustomerDataBindingSource
        {
            get { return customerBindingSource; }
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

    }
}

