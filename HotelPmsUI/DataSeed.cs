using DataAccessLibrary.Context;
using ArgonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HotelPmsUI
{
    public class DataSeed
    {
        private readonly HpmsDbContext context;

        public DataSeed(HpmsDbContext context)
        {
            this.context = context;
            SeedCategories();
            SeedUser();
#if (DEBUG)
            SeedCustomers();
            SeedRooms();
            SeedSatff();
#endif



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
            var roomTypes = context.TypeCategories.FirstOrDefault(rt => rt.id == 3 && rt.Type == 2);
            var count = context.Rooms.Count();
            if (count < 30 || !context.Rooms.Any())
            {
                List<DataAccessLibrary.Models.Room> rooms = [];

                for (int i = 0; i < 31; i++)
                {
                    rooms.Add(new()
                    {
                        RoomNumber = (i + 1).ToString(),
                        Floor = 1,
                        BedNumber = 2,
                        BathNumber = 1,
                        RoomTypeCategory = roomTypes!
                    });
                }
                context.Rooms.AddRange(rooms);
                context.SaveChanges();
            }
        }

        private void SeedUser()
        {
            var role = context.TypeCategories.FirstOrDefault(tc => tc.id == 1 && tc.Type == 3);

            if (role == null) return;

            if (!context.Users.Any())
            {
                DataAccessLibrary.Models.User user = new()
                {
                    UserName = "Admin",
                    Password = "Admin",
                    FullName = "Administrator",
                    UserRole = role
                };

                Argon2 hash = new();
                
                user.Password = hash.HashPassword(user.Password);

                context.Add(user);
                context.SaveChanges();
                
            }
        }

        private void SeedCategories()
        {
            if (!context.TypeCategories.Where(x => x.Type == 3).Any())
            {
                List<DataAccessLibrary.Models.TypeCategory> roles =
                [
                    new(){ id = 1, Description = "Administrator", Type = 3 },
                    new(){ id = 2, Description = "User", Type = 3}
                ];

                context.AddRange(roles);
                
            }

            if (!context.TypeCategories.Where(x => x.Type == 2).Any())
            {
                List<DataAccessLibrary.Models.TypeCategory> roomCategories =
                [
                    new(){ id = 3, Description = "Regular", Type = 2 }
                ];

                context.AddRange(roomCategories);
            }

            if(!context.TypeCategories.Where(x => x.Type == 1).Any())
            {
                List<DataAccessLibrary.Models.TypeCategory> specialties = 
                [
                    new() {id = 7, Description = "Groom", Type = 1}
                    
                ];

                context.AddRange(specialties);
                
            }

            context.SaveChanges();
        }

        private void SeedSatff()
        {
            var specialty = context.TypeCategories.Where(tc => tc.id == 7 && tc.Type == 1).FirstOrDefault();

            if (!context.Staff.Any())
            {
               for (int i = 0; i < 52; i++)
                {
                    DataAccessLibrary.Models.Staff staff = new()
                    {
                        FirstName = "name" + (i + 1).ToString(),
                        LastName = "lastname" + (i + 1).ToString(),
                        Specialty = specialty!
                    };

                    context.Add(staff);
                }

               context.SaveChanges();
            }
        }
    }
}
