using DataAccessLibrary.Context;
using HotelPms.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        public BindingSource CustomerDataBindingSource
        {
            get { return customerBindingSource; }
        }

        private void CustomerTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var currId = ((DataAccessLibrary.Models.Customer)CustomerDataBindingSource[e.RowIndex]).Id;
            CustomerService.Instance.CustomerId = currId;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CustomerCrudForm customerCrudForm = new CustomerCrudForm();
            HpmsDbContext context = new HpmsDbContext();
            var customer = context.Customers.FirstOrDefault(c => c.Id == CustomerService.Instance.CustomerId);
            customerCrudForm.CustomerBindingSource.DataSource = customer;
            customerCrudForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CustomerService.DeleteCustomer<HpmsDbContext>();
            CustomerService.ViewCustomers<HpmsDbContext, CustomerListForm>();
        }
    }
}

