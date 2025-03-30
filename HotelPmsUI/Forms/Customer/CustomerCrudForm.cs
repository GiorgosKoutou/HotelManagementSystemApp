using DataAccessLibrary.Context;
using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerCrudForm : Form
    {
        public BindingSource CustomerBindingSource { get => customerBindingSource; }
        private readonly CustomerService customer;

        public CustomerCrudForm(CustomerService customer)
        {
            InitializeComponent();
            this.customer = customer;
            customerBindingSource.AddNew();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = customer.CustomerId;

            if (id > 0)
            {
                customer.EdiData<DataAccessLibrary.Models.Customer>(customerBindingSource);
                id = 0;
                customerBindingSource.AddNew();
            }
            else
                customer.AddData<DataAccessLibrary.Models.Customer>(customerBindingSource);


        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<CustomerListForm>();
            customer.ViewData<DataAccessLibrary.Models.Customer>(form.CustomerDataBindingSource);
            form.Show();
        }
    }
}

