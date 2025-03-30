using DataAccessLibrary.Context;
using DataAccessLibrary.Models;
using HotelPmsUI.Forms.Customer;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.Marshalling;

namespace HotelPms.ModelServices
{
    public class CustomerService : Service 
    {
        public CustomerService(HpmsDbContext context) : base(context) {}

        public int CustomerId { get; set; } = 0;


        /// <summary>
        /// Views data from the database using the specified BindingSource.
        /// </summary>
        /// <typeparam name="TClass">The type of the entity to view.</typeparam>
        /// <param name="source">The BindingSource containing the data to view.</param>
        public override void ViewData<TClass>(BindingSource source)
        {
            base.ViewData<TClass>(source);
        }

        /// <summary>
        /// Adds data to the database using the specified BindingSource.
        /// </summary>
        /// <typeparam name="TClass">The type of the entity to add.</typeparam>
        /// <param name="source">The BindingSource containing the data to add.</param>
        /// <exception cref="DbUpdateException">
        /// Thrown when an error occurs while updating the database. 
        /// Specific error messages are displayed based on the exception details.
        /// </exception>
        public override void AddData<TClass>(BindingSource source)
        {
            try
            { 
                base.AddData<TClass>(source);
                MessageBox.Show("Customer Added Successfully.");
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
        /// <typeparam name="TClass">The type of the entity to edit.</typeparam>
        /// <param name="source">The BindingSource containing the data to edit.</param>
        /// <exception cref="DbUpdateException">
        /// Thrown when an error occurs while updating the database. 
        /// Specific error messages are displayed based on the exception details.
        /// </exception>
        public override void EdiData<TClass>(BindingSource source)
        {
            try
            {
                base.EdiData<TClass>(source);
                MessageBox.Show("Customer Update Successfully");
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
        /// <typeparam name="TClass">The type of the entity to delete.</typeparam>
        /// <typeparam name="TValueType">The type of the property name to use for deletion.</typeparam>
        /// <param name="propName">The property name used to identify the entity to delete.</param>
        /// <exception cref="NullReferenceException">
        /// Thrown when the entity to delete is not found in the database.
        /// </exception>
        public override void DeleteData<TClass, TValueType>(TValueType propName)
        {
            try
            {
                base.DeleteData<TClass, TValueType>(propName);   
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Customer Not Found");
            }
        }

        /// <summary>
        /// Finds data in the database using the specified property name.
        /// </summary>
        /// <typeparam name="TClass">The type of the entity to find.</typeparam>
        /// <typeparam name="TValueType">The type of the property name to use for finding the entity.</typeparam>
        /// <param name="propName">The property name used to identify the entity to find.</param>
        /// <returns>The found entity of type <typeparamref name="TClass"/>.</returns>
        /// <exception cref="NullReferenceException">
        /// Thrown when the entity to find is not found in the database.
        /// </exception>
        public override TClass FindData<TClass, TValueType>(TValueType propName)
        {
            try
            {
                return base.FindData<TClass, TValueType>(propName);
            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Customer Not Found");
                throw;
            }
        }


    }
}
