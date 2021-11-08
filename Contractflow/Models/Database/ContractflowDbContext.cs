using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Contractflow.Models.Database
{
    public partial class ContractflowDbContext : DbContext
    {
        public ContractflowDbContext()
        {
        }

        public ContractflowDbContext(DbContextOptions<ContractflowDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ContractflowDatabase"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Users_pk")
                    .IsClustered(false);

                entity.HasIndex(e => e.Dni, "Users_DNI_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "Users_Email_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "Users_Id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.PhoneNumber, "Users_PhoneNumber_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Salt, "Users_Salt_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "Users_Username_uindex")
                    .IsUnique();

                entity.Property(e => e.CreatedAt)
                    .HasPrecision(3)
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.DeletedAt).HasPrecision(3);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DNI");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasPrecision(3)
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
