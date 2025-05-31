using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using HotelPmsUI.Forms;
using Microsoft.EntityFrameworkCore;

namespace HotelPmsUI.ModelServices
{
    // The generics in the Service class and its derived classes allow for type-safe operations on entities.
    // TClass represents the type of the entity (e.g., Customer), and TValueType represents the type of the entity's key (e.g., int).
    // This enables the Service class to be reused for different entities and key types, providing flexibility and reducing code duplication.
    public class CustomerService : BaseService<DataAccessLibrary.Models.Customer, Forms.Customer.CustomerCrudForm, Forms.Customer.CustomerListForm>
    {
        public CustomerService(HpmsDbContext context) : base(context) {  }

        
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
            var originalTin = entry.OriginalValues["Tin"].ToString();
            var tinAfterEdit = entry.CurrentValues["Tin"].ToString();

            tinAfterEdit = (originalTin.Equals(tinAfterEdit)) ? string.Empty : entry.CurrentValues["Tin"].ToString();

            if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Modified && (tinExists == null || !tinAfterEdit.Equals(tinExists.Tin)))
            {
                base.SaveData();
                return;

            }

            
            if ( tinExists != null)
            {
                MessageBox.Show("Tax Identification Number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                base.SaveData();             
        }
    }
}
