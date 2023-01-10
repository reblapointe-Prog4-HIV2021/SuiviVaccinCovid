using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SuiviVaccinDBFirst.Modeles
{
    public partial class VaccinsContext : DbContext
    {
        public VaccinsContext()
        {
        }

        public VaccinsContext(DbContextOptions<VaccinsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dose> Doses { get; set; }
        public virtual DbSet<Immunisation> Immunisations { get; set; }
        public virtual DbSet<Vaccin> Vaccins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Vaccins;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dose>(entity =>
            {
                entity.HasIndex(e => e.VaccinId, "IX_Doses_VaccinId");

                entity.Property(e => e.Nampatient).HasColumnName("NAMPatient");

                entity.HasOne(d => d.Vaccin)
                    .WithMany(p => p.Doses)
                    .HasForeignKey(d => d.VaccinId);
            });

            modelBuilder.Entity<Immunisation>(entity =>
            {
                entity.HasIndex(e => e.VaccinId, "IX_Immunisations_VaccinId");

                entity.Property(e => e.ImmunisationId).HasColumnName("ImmunisationID");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Nampatient).HasColumnName("NAMPatient");

                entity.HasOne(d => d.Vaccin)
                    .WithMany(p => p.Immunisations)
                    .HasForeignKey(d => d.VaccinId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
