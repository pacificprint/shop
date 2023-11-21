using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PacificPrint.Shop.Data.Entities;

namespace PacificPrint.Shop.Data.Context;

public partial class PacificPrintContext : DbContext
{
    public PacificPrintContext()
    {
    }

    public PacificPrintContext(DbContextOptions<PacificPrintContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("clients_pkey");

            entity.ToTable("clients", "shop");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.HouseNumber).HasColumnName("house_number");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");
            entity.Property(e => e.Neighborhood).HasColumnName("neighborhood");
            entity.Property(e => e.OptionalName).HasColumnName("optional_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
            entity.Property(e => e.Postalcode).HasColumnName("postalcode");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
