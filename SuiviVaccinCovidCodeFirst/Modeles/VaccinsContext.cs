using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SuiviVaccinCovidCodeFirst.Modeles
{
    public class VaccinsContext : DbContext
    {
        public DbSet<Dose> Doses { get; set; }
        public DbSet<Vaccin> Vaccins { get; set; }
        public DbSet<Immunisation> Immunisations { get; set; }
        public DbSet<Covid19> CasCovid19 { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Vaccins;Trusted_Connection=True;");

    }
}


