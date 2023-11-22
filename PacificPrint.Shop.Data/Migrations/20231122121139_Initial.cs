using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PacificPrint.Shop.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "shop");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:shop.uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "clients",
                schema: "shop",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "shop.uuid_generate_v4()"),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    optional_name = table.Column<string>(type: "text", nullable: true),
                    middle_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    phone_number = table.Column<string>(type: "text", nullable: false),
                    company_name = table.Column<string>(type: "text", nullable: true),
                    street = table.Column<string>(type: "text", nullable: false),
                    house_number = table.Column<decimal>(type: "numeric", nullable: false),
                    neighborhood = table.Column<string>(type: "text", nullable: false),
                    postal_code = table.Column<decimal>(type: "numeric", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("clients_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                schema: "shop",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "shop.uuid_generate_v4()"),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    category = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unit_value = table.Column<decimal>(type: "numeric", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("products_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "shop",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "shop.uuid_generate_v4()"),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    optional_name = table.Column<string>(type: "text", nullable: true),
                    middle_name = table.Column<string>(type: "text", nullable: true),
                    last_name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                schema: "shop",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "shop.uuid_generate_v4()"),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    payment = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    payment_value = table.Column<decimal>(type: "numeric", nullable: false),
                    total_value = table.Column<decimal>(type: "numeric", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("orders_pk", x => x.id);
                    table.ForeignKey(
                        name: "orders_clients_id_fk",
                        column: x => x.client_id,
                        principalSchema: "shop",
                        principalTable: "clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "orders_users_id_fk",
                        column: x => x.user_id,
                        principalSchema: "shop",
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_detail",
                schema: "shop",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "shop.uuid_generate_v4()"),
                    order_id = table.Column<Guid>(type: "uuid", nullable: false),
                    product_id = table.Column<Guid>(type: "uuid", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unit_value = table.Column<decimal>(type: "numeric", nullable: false),
                    total_value = table.Column<decimal>(type: "numeric", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_detail_pk", x => x.id);
                    table.ForeignKey(
                        name: "order_detail_orders_id_fk",
                        column: x => x.order_id,
                        principalSchema: "shop",
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "order_detail_products_id_fk",
                        column: x => x.product_id,
                        principalSchema: "shop",
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_detail_order_id",
                schema: "shop",
                table: "order_detail",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_detail_product_id",
                schema: "shop",
                table: "order_detail",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_client_id",
                schema: "shop",
                table: "orders",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_user_id",
                schema: "shop",
                table: "orders",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_detail",
                schema: "shop");

            migrationBuilder.DropTable(
                name: "orders",
                schema: "shop");

            migrationBuilder.DropTable(
                name: "products",
                schema: "shop");

            migrationBuilder.DropTable(
                name: "clients",
                schema: "shop");

            migrationBuilder.DropTable(
                name: "users",
                schema: "shop");
        }
    }
}
