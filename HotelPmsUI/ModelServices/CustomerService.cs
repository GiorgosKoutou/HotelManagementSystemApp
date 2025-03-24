using DataAccessLibrary.Context;
using HotelPmsUI.Forms.Customer;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.Marshalling;

namespace HotelPms.ModelServices
{
    public class CustomerService
    {
        private static CustomerService instance = new();
        private CustomerService() { }

        public static CustomerService Instance { get => instance; }

        public int CustomerId { get; set; }

        /// <summary>
        /// Adds a new customer to the database.
        /// </summary>
        /// <typeparam name="T">The type of the DbContext to use.</typeparam>
        /// <param name="source">The BindingSource containing the customer data.</param>
        public static void AddCustomer<T>(BindingSource source) where T : new()
        {
            try
            {
                using (var context = new T() as HpmsDbContext)
                {
                    var customer = (DataAccessLibrary.Models.Customer)source.Current;
                    context.Add(customer);
                    context.SaveChanges();
                    MessageBox.Show("Customer Added Successfully.");
                    source.AddNew();
                }

            }
            catch (DbUpdateException e)
            {
                var inner = e.InnerException;
                string message = inner.Message;

                if (message.Contains("FirstName"))
                    MessageBox.Show("First Name cannot be empty");

                if (message.Contains("LastName"))
                    MessageBox.Show("Last Name cannot be empty");


                if (message.Contains("Tin"))
                {
                    if (message.Contains("Column Tin"))
                        MessageBox.Show("Tax Identificational Number cannot be empty");

                    else if (message.Contains("customers.IX_Customers_Tin"))
                        MessageBox.Show("Tax Identificational Number already exists");

                    else
                        MessageBox.Show(message);

                }


            }

        }

        /// <summary>
        /// Displays a list of customers.
        /// </summary>
        /// <typeparam name="T1">The type of the DbContext to use.</typeparam>
        /// <typeparam name="T2">The type of the form to display the customer list.</typeparam>
        public static void ViewCustomers<T1, T2>() where T1 : new() where T2 : new()
        {
            using (var context = new T1() as HpmsDbContext)
            {
                var customerList = new T2() as CustomerListForm;

                customerList.CustomerDataBindingSource.DataSource = context.Customers.ToList();
                customerList.Show();

            }

        }

        /// <summary>
        /// Edits an existing customer in the database.
        /// </summary>
        /// <typeparam name="T">The type of the DbContext to use.</typeparam>
        /// <param name="source">The BindingSource containing the customer data.</param>
        public static void EditCustomer<T>(BindingSource source) where T : new()
        {
            using (var context = new T() as HpmsDbContext)
            {
                try
                {
                    var customer = (DataAccessLibrary.Models.Customer)source.Current;
                    context.Customers.Update(customer);
                    context.SaveChanges();
                    MessageBox.Show("Customer Update Success");
                }
                catch (DbUpdateException e)
                {
                    var inner = e.InnerException;
                    string message = inner.Message;

                    if (message.Contains("FirstName"))
                        MessageBox.Show("First Name cannot be empty");

                    if (message.Contains("LastName"))
                        MessageBox.Show("Last Name cannot be empty");


                    if (message.Contains("Tin"))
                    {
                        if (message.Contains("Column Tin"))
                            MessageBox.Show("Tax Identificational Number cannot be empty");

                        else if (message.Contains("customers.IX_Customers_Tin"))
                            MessageBox.Show("Tax Identificational Number already exists");

                        else
                            MessageBox.Show(message);

                    }


                }

            }
        }

        /// <summary>
        /// Deletes a customer from the database.
        /// </summary>
        /// <typeparam name="T">The type of the DbContext to use.</typeparam>
        public static void DeleteCustomer<T>() where T : new()
        {
            using (var context = new T() as HpmsDbContext)
            {
                var customer = context.Customers.FirstOrDefault(c => c.Id == CustomerService.Instance.CustomerId);
                context.Customers.Remove(customer);
                context.SaveChanges();
                MessageBox.Show("Customer Deleted");
            }
        }
    }
}
