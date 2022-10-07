using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Client.DataTransferObjects
{
    public partial class MarquesaSystemContext : DbContext
    {
        public MarquesaSystemContext()
        {
        }

        public MarquesaSystemContext(DbContextOptions<MarquesaSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientInfo> ClientInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=MarquesaSystem;Username=postgres;Password=postgres");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ClientInfo>(entity =>
            {
                entity.ToTable("ClientInfo", "Identity");

                entity.HasIndex(e => e.Id, "ClientInfo_Id_key")
                    .IsUnique();

                entity.Property(e => e.Address).HasColumnType("character varying");

                entity.Property(e => e.Email).HasColumnType("character varying");

                entity.Property(e => e.FirstName).HasColumnType("character varying");

                entity.Property(e => e.LastName).HasColumnType("character varying");

                entity.Property(e => e.MobileNumber).HasColumnType("character varying");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
