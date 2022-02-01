using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SuiviVaccinCovidCodeFirst.Modeles
{
    public class VaccinContext : DbContext
    {
        public DbSet<Vaccin> Vaccins { get; set; }
        public DbSet<TypeVaccin> TypesVaccin { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VaccinBD;Trusted_Connection=True;");
    }
}


