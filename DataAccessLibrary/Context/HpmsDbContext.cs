using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<TypeCatgory> TypeCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                        .HasIndex(c => c.Tin)
                        .IsUnique();

            modelBuilder.Entity<Room>()
                        .HasOne(r => r.RoomTypeCategory)
                        .WithMany()
                        .HasForeignKey(r => new { r.RoomTypeId, r.RoomType });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connectionstring = ConfigurationManager.ConnectionStrings["HpmsMySql"].ConnectionString;

                optionsBuilder.UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring));
        }
    }
}
