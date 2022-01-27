using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SuiviVaccinDBFirst.ModelesBD
{
    public partial class VaccinBDContext : DbContext
    {
        public VaccinBDContext()
        {
        }

        public VaccinBDContext(DbContextOptions<VaccinBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TypesVaccin> TypesVaccin { get; set; }
        public virtual DbSet<Vaccins> Vaccins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VaccinBD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypesVaccin>(entity =>
            {
                entity.HasKey(e => e.TypeVaccinId);
            });

            modelBuilder.Entity<Vaccins>(entity =>
            {
                entity.HasKey(e => e.VaccinId);

                entity.HasIndex(e => e.TypeVaccinId);

                entity.Property(e => e.Nampatient).HasColumnName("NAMPatient");

                entity.HasOne(d => d.TypeVaccin)
                    .WithMany(p => p.Vaccins)
                    .HasForeignKey(d => d.TypeVaccinId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
