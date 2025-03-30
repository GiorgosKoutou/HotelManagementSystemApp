using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerListForm : Form
    {
        private readonly CustomerService customerService;
        private readonly Forms.Customer.CustomerCrudForm form;

        public CustomerListForm(CustomerService customer, CustomerCrudForm form)
        {
            InitializeComponent();
            this.customerService = customer;
            this.form = form;
        }

        public BindingSource CustomerDataBindingSource
        {
            get { return customerBindingSource; }
        }

        private void CustomerTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var currId = ((DataAccessLibrary.Models.Customer)CustomerDataBindingSource[e.RowIndex]).Id;
            customerService.CustomerId = currId;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var customer = customerService.FindData<DataAccessLibrary.Models.Customer, int>(customerService.CustomerId);
            form.CustomerBindingSource.DataSource = customer;
            form.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete the customer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                customerService.DeleteData<DataAccessLibrary.Models.Customer, int>(customerService.CustomerId);
                CustomerListForm customerListForm = new(customerService,form);
                customerService.ViewData<DataAccessLibrary.Models.Customer>(customerListForm.CustomerDataBindingSource);
                MessageBox.Show("Customer Deleted Successfully");
                customerListForm.Show();
            }
            else
                return;

        }

        private void CustomerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerService.CustomerId = 0;
        }

        private void CustomerTable_DoubleClick(object sender, EventArgs e)
        {
            var customer = customerService.FindData<DataAccessLibrary.Models.Customer, int>(customerService.CustomerId);
            form.CustomerBindingSource.DataSource = customer;
            form.Show();
        }
    }
}

