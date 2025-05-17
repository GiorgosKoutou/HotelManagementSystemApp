using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerCrudForm : Form
    {


        private readonly CustomerService customer;
        private readonly DataAccessLibrary.Models.Customer customerModel;


        public CustomerCrudForm(CustomerService customer, DataAccessLibrary.Models.Customer customerModel)
        {
            InitializeComponent();
            this.customer = customer;
            customerBindingSource.DataSource = customer.BindingSource;
            this.customerModel = customerModel;
        }
        public BindingSource? CustomerBindingSource { get => customerBindingSource; }


        private void AddButton_Click(object sender, EventArgs e)
        {
            customer.SaveData();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                customer.ViewData();
            }
            else
                return;
        }

    }
}

