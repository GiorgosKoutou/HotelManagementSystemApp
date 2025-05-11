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

                string message = e.InnerException.Message;
                isAdded = false;

                if (message.Contains("Tin"))
                {
                    if (message.Contains("null"))
                    {
                        MessageBox.Show("Tax Identificational Number cannot be empty");
                        transaction?.Rollback();
                    }
                        
                    else if (message.Contains("customers.IX_Customers_Tin"))
                    {
                        MessageBox.Show("Tax Identificational Number already exists");
                        transaction?.Rollback();
                    }

                    else
                    {
                        MessageBox.Show(message);
                        transaction?.Rollback();
                    }
                        
                }
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
