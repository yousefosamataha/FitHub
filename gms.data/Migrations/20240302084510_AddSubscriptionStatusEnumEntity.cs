using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscriptionStatusEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.SubscriptionStatusEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.SubscriptionStatusEnum", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "gms.SubscriptionStatusEnum",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionStatus" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1696), false, null, "Active" },
                    { 2, new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1705), false, null, "Suspend" },
                    { 3, new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1708), false, null, "Cancelled" },
                    { 4, new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1710), false, null, "Expired" }
                });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(3840));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SubscriptionStatusEnum");

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 41, 15, 984, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 41, 15, 984, DateTimeKind.Utc).AddTicks(5924));
        }
    }
}
