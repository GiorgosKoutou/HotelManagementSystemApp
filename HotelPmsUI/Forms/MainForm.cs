using HotelPmsUI.Forms.Customer;
using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsUI.Forms
{
    public partial class MainForm : Form
    {
        //private readonly Forms.Customer.CustomerCrudForm form;
        private readonly Forms.Customer.CustomerListForm form;
        private readonly ModelServices.CustomerService customer;


        public MainForm(Forms.Customer.CustomerListForm form, CustomerService customer)
        {
            InitializeComponent();
            this.form = form;
            this.customer = customer;
        }

    }
}

