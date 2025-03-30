using DataAccessLibrary.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPmsUI
{
    public class DataSeed
    {
        private readonly HpmsDbContext context;

        public DataSeed(HpmsDbContext context)
        {
            this.context = context;
            SeedCustomers();
        }


        private void SeedCustomers()
        {
            
            if (!context.Customers.Any())
            {
                List<DataAccessLibrary.Models.Customer> customers = [];

                for (int i = 0; i < 100; i++)
                {

                    customers.Add(new()
                    {
                        FirstName = "name" + (i + 1).ToString(),
                        LastName = "LastName" + (i + 1).ToString(),
                        Tin = (i + 1).ToString(),
                        Country = "Country" + (i + 1).ToString(),
                        City = "City" + (i + 1).ToString(),
                        Address = "Address" + (i + 1).ToString(),
                        PhoneNumber = "69999999999"
                    });
                }
                context.Customers.AddRange(customers);
                context.SaveChanges();
            }
            
        }
    }
}
