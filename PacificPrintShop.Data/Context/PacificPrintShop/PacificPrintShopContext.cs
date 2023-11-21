using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PacificPrintShop.Data.Models.PacificPrintShop;

namespace PacificPrintShop.Data.Context.PacificPrintShop;

public partial class PacificPrintShopContext : DbContext
{
    public PacificPrintShopContext()
    {
    }

    public PacificPrintShopContext(DbContextOptions<PacificPrintShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("clients");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.Country).HasColumnName("country");
            entity.Property(e => e.FirstName).HasColumnName("firstName");
            entity.Property(e => e.HouseNumber).HasColumnName("houseNumber");
            entity.Property(e => e.LastName).HasColumnName("lastName");
            entity.Property(e => e.MiddleName).HasColumnName("middleName");
            entity.Property(e => e.Neighborhood).HasColumnName("neighborhood");
            entity.Property(e => e.OptionalName).HasColumnName("optionalName");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
            entity.Property(e => e.PostalCode).HasColumnName("postalCode");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Street).HasColumnName("street");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
