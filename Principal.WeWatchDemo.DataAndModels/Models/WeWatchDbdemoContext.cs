using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Principal.WeWatchDemo.DataAndModels.Models
{
    public partial class WeWatchDbdemoContext : DbContext
    {
        public WeWatchDbdemoContext()
        {
        }

        public WeWatchDbdemoContext(DbContextOptions<WeWatchDbdemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Evidences> Evidences { get; set; }
        public virtual DbSet<Incidents> Incidents { get; set; }
        public virtual DbSet<Medias> Medias { get; set; }
        public virtual DbSet<RejectedRequests> RejectedRequests { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=WeWatchDbdemo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evidences>(entity =>
            {
                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.Evidences)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evidences_Incidents");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Evidences)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Evidences_Users");
            });

            modelBuilder.Entity<Incidents>(entity =>
            {
                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidents_Users");
            });

            modelBuilder.Entity<Medias>(entity =>
            {
                entity.HasOne(d => d.Evidence)
                    .WithMany(p => p.Medias)
                    .HasForeignKey(d => d.EvidenceId)
                    .HasConstraintName("FK_Medias_Evidences");

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.Medias)
                    .HasForeignKey(d => d.IncidentId)
                    .HasConstraintName("FK_Medias_Incidents");
            });

            modelBuilder.Entity<RejectedRequests>(entity =>
            {
                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.RejectedRequests)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RejectedRequests_Incidents");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.RejectedRequests)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RejectedRequests_Users");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reports_Incidents");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
