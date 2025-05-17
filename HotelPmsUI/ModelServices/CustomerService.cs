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

            var tinExists = Context.Customers.FirstOrDefault(c => c.Tin == currentRecord.Tin);

            if(message != null)
            {
                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction?.Rollback();
                return;
            }

            if ( tinExists != null )
            {
                MessageBox.Show("Tax Identification Number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction?.Rollback();
                return;
            }

            try
            {
                if (isNew)
                    MessageBox.Show("Customer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Customer Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                base.SaveData();
                transaction?.Commit();
               
                
            }
            catch (DbUpdateException e)
            {

                string errorMessage = e.InnerException!.Message;
                isAdded = false;
                MessageBox.Show($"Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction?.Rollback();
            }
        }

        public override void DeleteData()
        {

            try
            {
                base.DeleteData();
                MessageBox.Show("Delete Success");
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Please select a customer");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Customer not found");
            }
        }
    }
}
