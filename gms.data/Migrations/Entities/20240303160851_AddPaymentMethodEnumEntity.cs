using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class AddPaymentMethodEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.PaymentMethodEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.PaymentMethodEnum", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "gms.PaymentMethodEnum",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "PaymentMethod" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 3, 16, 8, 50, 417, DateTimeKind.Utc).AddTicks(4392), false, null, "Cash" },
                    { 2, new DateTime(2024, 3, 3, 16, 8, 50, 417, DateTimeKind.Utc).AddTicks(4476), false, null, "Credit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.PaymentMethodEnum");
        }
    }
}
