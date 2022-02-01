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

        public virtual DbSet<Immunisations> Immunisations { get; set; }
        public virtual DbSet<TypesVaccin> TypesVaccin { get; set; }

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
            modelBuilder.Entity<Immunisations>(entity =>
            {
                entity.HasKey(e => e.ImmunisationId);

                entity.HasIndex(e => e.TypeVaccinId);

                entity.Property(e => e.ImmunisationId).HasColumnName("ImmunisationID");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Nampatient).HasColumnName("NAMPatient");

                entity.HasOne(d => d.TypeVaccin)
                    .WithMany(p => p.Immunisations)
                    .HasForeignKey(d => d.TypeVaccinId);
            });

            modelBuilder.Entity<TypesVaccin>(entity =>
            {
                entity.HasKey(e => e.TypeVaccinId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
