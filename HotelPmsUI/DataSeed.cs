using DataAccessLibrary.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            SeedRooms();
            SeedCategories();
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

        private void SeedRooms()
        {
            if (!context.Rooms.Any())
            {
                List<DataAccessLibrary.Models.Room> rooms = [];

                for (int i = 0; i < 20; i++)
                {
                    rooms.Add(new()
                    {
                        RoomNumber = (i + 1).ToString(),
                        Floor = 1,
                        BedNumber = 2,
                        BathNumber = 1,
                        RoomTypeId = 3,
                        RoomType = 2
                    });
                }
                context.Rooms.AddRange(rooms);
                context.SaveChanges();
            }
        }

        private void SeedCategories()
        {
            if (!context.TypeCategories.Where(x => x.Type == 3).Any())
            {
                List<DataAccessLibrary.Models.TypeCatgory> roles =
                [
                    new(){ id = 1, Description = "Administrator", Type = 3 },
                    new(){ id = 2, Description = "User", Type = 3}
                ];

                context.AddRange(roles);
                context.SaveChanges();
            }
        }
    }
}
