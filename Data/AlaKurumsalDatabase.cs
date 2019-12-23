using System;
using System.Collections.Generic;
using System.Text;
using MertKaymaz_301Project.Data;
using Microsoft.EntityFrameworkCore;

namespace MertKaymaz_301Project.Data
{
    class AlaKurumsalDatabase : DbContext
    {
        string connectionString = @"Server=.\sqlexpress;Database=AlaKurumsalDatabase;Trusted_Connection=True;";
        public DbSet<Owner> Owners{ get; set; }
        public DbSet<Vehicle> Vehicles{ get; set; }

        public AlaKurumsalDatabase() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }


}
