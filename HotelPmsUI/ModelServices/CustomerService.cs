using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using HotelPmsUI.Forms;
using Microsoft.EntityFrameworkCore;

namespace HotelPmsUI.ModelServices
{
    public class CustomerService : BaseService<DataAccessLibrary.Models.Customer, 
                                  Forms.Customer.CustomerCrudForm, Forms.Customer.CustomerListForm, Forms.Customer.CustomerFilterForm>
    {
        public CustomerService(HpmsDbContext context) : base(context) 
        {
            var table = Context.Customers;
            SetRecords(table);
        }

        
        public override void ViewData()
        {
            base.ViewData();
        }

        public override void SaveData()
        {
            var currentRecord = (DataAccessLibrary.Models.Customer)BindingSource!.Current;
            currentRecord.FirstName = currentRecord.FirstName?.Trim();
            currentRecord.LastName = currentRecord.LastName?.Trim();
            currentRecord.Tin = currentRecord.Tin?.Trim();

            var message = CheckFields();
            if (message != null)
            {
                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var tinExists = Context.Customers.FirstOrDefault(c => c.Tin == currentRecord.Tin);

            var entry = Context.Entry(currentRecord);

            if (entry!.State == Microsoft.EntityFrameworkCore.EntityState.Modified)
            {
                base.SaveData();
                return;

            }


            if (tinExists != null)
            {
                MessageBox.Show("Tax Identification Number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            base.SaveData();             
        }
    }
}
