using HotelPmsUI.Forms.Customer;
using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsUI.Forms
{
    public partial class MainForm : Form
    {
        public Control MainPanel { get => mainPanel; }


        private readonly Forms.Customer.CustomerListForm customerListForm;
        private readonly ModelServices.CustomerService customerService;
        private readonly Forms.Customer.CustomerCrudForm customerCrudForm;

        private readonly Modules.CustomerModule customerModule;
        


        public MainForm(Forms.Customer.CustomerListForm form, CustomerService customer, CustomerCrudForm customerCrudForm, Modules.CustomerModule customerModule)
        {
            InitializeComponent();
            this.customerListForm = form;
            this.customerService = customer;
            this.customerCrudForm = customerCrudForm;
            this.customerModule = customerModule;
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            customerModule.ShowForm(mainPanel, customerListForm);
            customerService.ViewData(customerListForm.CustomerDataBindingSource);
            customerListForm.CustomerTable.ClearSelection();
            customerListForm.CustomerTable.CurrentCell = null;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            customerModule.ShowForm(mainPanel, customerCrudForm);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var customer = customerService.FindData(customerService.CustomerId);
            customerCrudForm.CustomerBindingSource.DataSource = customer;
            customerModule.ShowForm(mainPanel, customerCrudForm);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete the data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                customerService.DeleteData(customerService.CustomerId);
                customerModule.ShowForm(mainPanel, customerListForm);
                customerService.ViewData(customerListForm.CustomerDataBindingSource);
            }
            else
            {
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var seed = Program.ServiceProvider.GetRequiredService<DataSeed>();
        }
    }
}

