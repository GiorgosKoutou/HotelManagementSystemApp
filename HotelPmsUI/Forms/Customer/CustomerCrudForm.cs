using DataAccessLibrary.Context;
using HotelPms.ModelServices;
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
        public CustomerCrudForm()
        {
            InitializeComponent();
            customerBindingSource.AddNew();
        }

        public BindingSource CustomerBindingSource { get => customerBindingSource; }
        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = CustomerService.Instance.CustomerId;

            if (id > 0)
            {
                CustomerService.Instance.EdiData<HpmsDbContext, DataAccessLibrary.Models.Customer>(customerBindingSource);
                id = 0;
                customerBindingSource.AddNew();
            }
            else
                CustomerService.Instance.AddData<HpmsDbContext, DataAccessLibrary.Models.Customer>(customerBindingSource);
                

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            CustomerListForm frm = new CustomerListForm();
            CustomerService.Instance.ViewData<HpmsDbContext, DataAccessLibrary.Models.Customer>(frm.CustomerDataBindingSource);
            frm.Show();
        }
    }
}

