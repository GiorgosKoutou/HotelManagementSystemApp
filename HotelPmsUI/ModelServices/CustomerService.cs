using DataAccessLibrary.Context;
using HotelPmsUI.Forms;
using Microsoft.EntityFrameworkCore;

namespace HotelPmsUI.ModelServices
{
    // The generics in the Service class and its derived classes allow for type-safe operations on entities.
    // TClass represents the type of the entity (e.g., Customer), and TValueType represents the type of the entity's key (e.g., int).
    // This enables the Service class to be reused for different entities and key types, providing flexibility and reducing code duplication.
    public class CustomerService : BaseService<DataAccessLibrary.Models.Customer, Forms.Customer.CustomerCrudForm, Forms.Customer.CustomerListForm>
    {

        public CustomerService(HpmsDbContext context) : base(context) { }
        

        /// <summary>
        /// Views data from the database using the specified BindingSource.
        /// </summary>
        /// <param name="source">The BindingSource containing the data to view.</param>
        public override void ViewData()
        {
            base.ViewData();
        }

        /// <summary>
        /// Adds data to the database using the specified BindingSource.
        /// </summary>
        /// <param name="source">The BindingSource containing the data to add.</param>
        /// <exception cref="DbUpdateException">
        /// Thrown when an error occurs while updating the database. 
        /// Specific error messages are displayed based on the exception details.
        /// </exception>
        public override void SaveData()
        {
            try
            {
                base.SaveData();
            }
            catch (DbUpdateException e)
            {
                string message = e.InnerException.Message;

                if (message.Contains("FirstName"))
                    MessageBox.Show("First Name cannot be empty");

                if (message.Contains("LastName"))
                    MessageBox.Show("Last Name cannot be empty");

                if (message.Contains("Tin"))
                {
                    if (message.Contains("null"))
                        MessageBox.Show("Tax Identificational Number cannot be empty");

                    else if (message.Contains("customers.IX_Customers_Tin"))
                        MessageBox.Show("Tax Identificational Number already exists");

                    else
                        MessageBox.Show(message);
                }
            }
        }

        /// <summary>
        /// Edits data in the database using the specified BindingSource.
        /// </summary>
        /// <param name="source">The BindingSource containing the data to edit.</param>
        /// <exception cref="DbUpdateException">
        /// Thrown when an error occurs while updating the database. 
        /// Specific error messages are displayed based on the exception details.
        /// </exception>
        public override void EditData()
        {
            //SetCrudBindingSource(CustomerCrudForm.CustomerBindingSource);
            try
            {
                base.EditData();
                //MessageBox.Show("Customer Update Successfully");
            }
            catch (DbUpdateException e)
            {
                string message = e.InnerException.Message;

                if (message.Contains("FirstName"))
                    MessageBox.Show("First Name cannot be empty");

                if (message.Contains("LastName"))
                    MessageBox.Show("Last Name cannot be empty");

                if (message.Contains("Tin"))
                {
                    if (message.Contains("null"))
                        MessageBox.Show("Tax Identificational Number cannot be empty");

                    else if (message.Contains("customers.IX_Customers_Tin"))
                        MessageBox.Show("Tax Identificational Number already exists");

                    else
                        MessageBox.Show(message);
                }
            }
        }

        /// <summary>
        /// Deletes data from the database using the specified property name.
        /// </summary>
        /// <param name="propName">The property name used to identify the entity to delete.</param>
        /// <exception cref="NullReferenceException">
        /// Thrown when the entity to delete is not found in the database.
        /// </exception>
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
