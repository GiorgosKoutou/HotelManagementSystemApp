using HotelPmsUI.ModelServices;
using HotelPmsUI.Modules;
using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsUI.Forms.Customer
{
    public partial class CustomerCrudForm : Form
    {
        public BindingSource CustomerBindingSource { get => customerBindingSource; }

        private readonly CustomerService customerService;
        private readonly CustomerListForm customerListForm;

        private readonly CustomerModule customerModule;




        public CustomerCrudForm(CustomerService customer, CustomerListForm customerListForm, CustomerModule customerModule)
        {
            InitializeComponent();
            this.customerService = customer;
            this.customerListForm = customerListForm;

            customerBindingSource.AddNew();
            this.customerModule = customerModule;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = customerService.CustomerId;
            var mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();


            if (id > 0)
            {
                customerService.EdiData(customerBindingSource);
                id = 0;

                customerModule.ShowForm(mainForm.MainPanel, customerListForm);
                customerService.ViewData(customerListForm.CustomerDataBindingSource);
            }
            else
            {
                customerService.AddData(customerBindingSource);
                customerService.ViewData(customerListForm.CustomerDataBindingSource);
                customerModule.ShowForm(mainForm.MainPanel, customerListForm);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();
                customerModule.ShowForm(mainForm.MainPanel, customerListForm);
                customerService.ViewData(customerListForm.CustomerDataBindingSource);
                customerBindingSource.AddNew();
                customerService.CustomerId = 0;
            }else 
                return;
        }
    }
}

