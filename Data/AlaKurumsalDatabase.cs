using System;
using System.Collections.Generic;
using System.Text;
using MertKaymaz_301Project.Data;
using MertKaymaz_301Project.Service;
using Microsoft.EntityFrameworkCore;

namespace MertKaymaz_301Project.Data
{
    class AlaKurumsalDatabase : DbContext
    {
        string connectionString = @"Server=.\sqlexpress;Database=AlaKurumsalDatabase;Trusted_Connection=True;";
        public DbSet<Owner> Owners{ get; set; }
        public DbSet<Vehicle> Vehicles{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public AlaKurumsalDatabase() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Owner>().HasData(
              new Owner
              {
                  Id = 1,
                  Name = "Ozkan",
                  Surname = "Kaymaz",
                  Age = 40,
                  PhoneNo = "532273",
                  Mail = "ozkan.kaymaz@alakurumsal.com",
                  Password = new Service.AlaService().hashPassword("ozkan123"),

                  //Password = new Service.CetUserService().hashPassword("admin"),

              }
          ) ;
            modelBuilder.Entity<Owner>().HasData(
              new Owner
              {
                  Id = 2,
                  Name = "Kenan",
                  Surname = "İlten",
                  Age = 36,
                  PhoneNo = "532631",
                  Mail = "kenan.ilten@alakurumsal.com",
                  Password = new Service.AlaService().hashPassword("kenan123"),

                  //Password = new Service.CetUserService().hashPassword("admin"),

              }
          );

        }
    }


}
