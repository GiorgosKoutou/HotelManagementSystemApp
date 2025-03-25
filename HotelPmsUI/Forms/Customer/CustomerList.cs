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
            var customer = CustomerService.Instance.FindData<HpmsDbContext, DataAccessLibrary.Models.Customer, int>(CustomerService.Instance.CustomerId);
            customerCrudForm.CustomerBindingSource.DataSource = customer;
            customerCrudForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete the customer?", "Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                CustomerService.Instance.DeleteData<HpmsDbContext, DataAccessLibrary.Models.Customer, int>(CustomerService.Instance.CustomerId);
                CustomerListForm customerListForm = new CustomerListForm();
                CustomerService.Instance.ViewData<HpmsDbContext, DataAccessLibrary.Models.Customer>(customerListForm.CustomerDataBindingSource);
                MessageBox.Show("Customer Deleted Successfully");
                customerListForm.Show();
            } else
                return;
            
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            CustomerTable.ClearSelection();
        }
    }
}

