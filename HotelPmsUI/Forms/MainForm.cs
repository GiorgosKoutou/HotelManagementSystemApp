using HotelPmsUI.Forms.Customer;
using HotelPmsUI.ModelServices;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace HotelPmsUI.Forms
{
    public partial class MainForm : Form
    {

        private ModelServices.IService? currentModule;


        private readonly Forms.Customer.CustomerListForm customerListForm;
        private readonly Forms.Customer.CustomerCrudForm customerCrudForm;


        private static MainForm? instance = null;

        public MainForm(Forms.Customer.CustomerListForm form, CustomerCrudForm customerCrudForm)
        {
            InitializeComponent();
            this.customerListForm = form;
            this.customerCrudForm = customerCrudForm;
            instance = this;
        }

        public static Control? Mainpanel { get => instance?.mainPanel; }

        private void customerButton_Click(object sender, EventArgs e)
        {
            newButton.Enabled = true;
            editButton.Enabled = true;

            currentModule = Program.ServiceProvider.GetService<ModelServices.CustomerService>();

            currentModule.SetBindingSource(customerListForm.CustomerDataBindingSource, customerCrudForm.CustomerBindingSource);
            currentModule.SetPanel(mainPanel);
            currentModule.SetForms(customerCrudForm, customerListForm);

            currentModule?.ViewData();
        }

        private void newButton_Click(object sender, EventArgs e)
        {   
            editButton.Enabled = false;
            currentModule?.NewData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            newButton.Enabled = false;
            currentModule?.EditData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete the data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                currentModule?.DeleteData();
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

