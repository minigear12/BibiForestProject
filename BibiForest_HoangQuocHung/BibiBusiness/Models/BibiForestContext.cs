using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BibiBusiness.Models;

public partial class BibiForestContext : DbContext
{
    public BibiForestContext()
    {
    }

    public BibiForestContext(DbContextOptions<BibiForestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bibi> Bibis { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("BibiForest"));
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  //      => optionsBuilder.UseSqlServer("server=(local);database=BibiForest;uid=hung;pwd=12345678;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bibi>(entity =>
        {
            entity.HasKey(e => e.BibiId).HasName("PK__Bibi__F577BEAA3271B419");

            entity.ToTable("Bibi");

            entity.Property(e => e.BibiId)
                .ValueGeneratedNever()
                .HasColumnName("BibiID");
            entity.Property(e => e.BibiName).HasMaxLength(20);
            entity.Property(e => e.Country).HasMaxLength(20);
            entity.Property(e => e.Food).HasMaxLength(20);
            entity.Property(e => e.Forest).HasMaxLength(20);
            entity.Property(e => e.OwnerId)
                .HasMaxLength(20)
                .HasColumnName("OwnerID");
            entity.Property(e => e.Password).HasMaxLength(40);

            entity.HasOne(d => d.Owner).WithMany(p => p.Bibis)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bibi__OwnerID__5DCAEF64");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.OwnerId).HasName("PK__Owner__81938598D114B7B8");

            entity.ToTable("Owner");

            entity.Property(e => e.OwnerId)
                .HasMaxLength(20)
                .HasColumnName("OwnerID");
            entity.Property(e => e.OwnerName).HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
