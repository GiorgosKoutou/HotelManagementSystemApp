using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Context
{
    public class HpmsDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<TypeCategory> TypeCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Period> Period { get; set; }
        public DbSet<PriceList> PriceList { get; set; }
        public DbSet<PriceListDetail> PriceListDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connectionstring = ConfigurationManager.ConnectionStrings["HpmsMySql"].ConnectionString;

                optionsBuilder.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring));
        }
    }
}
