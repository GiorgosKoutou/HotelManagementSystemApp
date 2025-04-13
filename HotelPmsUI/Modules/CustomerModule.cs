using HotelPmsUI.Forms;
using HotelPmsUI.Forms.Customer;
using HotelPmsUI.ModelServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI.Modules
{
    public class CustomerModule : BaseModule <Forms.Customer.CustomerCrudForm, Forms.Customer.CustomerListForm>
    {
        private readonly ModelServices.CustomerService service;
        private readonly CustomerListForm customerListForm;

        public CustomerModule(CustomerService service, CustomerListForm customerListForm)
        {
            this.service = service;
            this.customerListForm = customerListForm;
        }


        public override void ShowForm(Control panel, Form form)
        {
            base.ShowForm(panel, form);
        }
    }
}
