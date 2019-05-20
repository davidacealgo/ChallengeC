using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChallengeC.Models
{
    public partial class ChallengeContext : DbContext
    {
        public ChallengeContext()
        {
        }

        public ChallengeContext(DbContextOptions<ChallengeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Municipality> Municipality { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Challenge;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Municipality>(entity =>
            {
                entity.HasKey(e => e.Idmunicipality)
                    .HasName("PK__municipa__7AB36D1B2B0E8560");

                entity.Property(e => e.Idmunicipality).ValueGeneratedNever();

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
