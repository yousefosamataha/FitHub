using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscriptionTypeEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.SubscriptionTypeEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.SubscriptionTypeEnum", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "gms.SubscriptionTypeEnum",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 2, 8, 41, 15, 984, DateTimeKind.Utc).AddTicks(5900), false, null, "Monthly" },
                    { 2, new DateTime(2024, 3, 2, 8, 41, 15, 984, DateTimeKind.Utc).AddTicks(5924), false, null, "Annually" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SubscriptionTypeEnum");
        }
    }
}
