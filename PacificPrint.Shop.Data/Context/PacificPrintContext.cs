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

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasPostgresExtension("shop", "uuid-ossp");

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("clients_pkey");

            entity.ToTable("clients", "shop");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("shop.uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.CompanyName).HasColumnName("company_name");
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
            entity.Property(e => e.PostalCode).HasColumnName("postal_code");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pk");

            entity.ToTable("orders", "shop");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("shop.uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Payment)
                .HasDefaultValue(0)
                .HasColumnName("payment");
            entity.Property(e => e.PaymentValue).HasColumnName("payment_value");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasColumnName("status");
            entity.Property(e => e.TotalValue).HasColumnName("total_value");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Client).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("orders_clients_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("orders_users_id_fk");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_detail_pk");

            entity.ToTable("order_detail", "shop");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("shop.uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(0)
                .HasColumnName("quantity");
            entity.Property(e => e.TotalValue).HasColumnName("total_value");
            entity.Property(e => e.UnitValue).HasColumnName("unit_value");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("order_detail_orders_id_fk");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("order_detail_products_id_fk");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pk");

            entity.ToTable("products", "shop");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("shop.uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasDefaultValue(0)
                .HasColumnName("category");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.UnitValue).HasColumnName("unit_value");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pk");

            entity.ToTable("users", "shop");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("shop.uuid_generate_v4()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.MiddleName).HasColumnName("middle_name");
            entity.Property(e => e.OptionalName).HasColumnName("optional_name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Role)
                .HasDefaultValue(0)
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
