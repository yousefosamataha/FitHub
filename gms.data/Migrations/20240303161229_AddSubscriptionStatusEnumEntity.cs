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
                    BadgeColorId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.SubscriptionStatusEnum", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.InsertData(
                table: "gms.SubscriptionStatusEnum",
                columns: new[] { "Id", "BadgeColorId", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionStatus" },
                values: new object[,]
                {
                    { 1, (byte)2, new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(4106), false, null, "Active" },
                    { 2, (byte)4, new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(4115), false, null, "Suspend" },
                    { 3, (byte)6, new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(4117), false, null, "Cancelled" },
                    { 4, (byte)3, new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(4119), false, null, "Expired" }
                });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 12, 28, 469, DateTimeKind.Utc).AddTicks(6982));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SubscriptionStatusEnum");

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 10, 37, 111, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 10, 37, 111, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 10, 37, 112, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 10, 37, 112, DateTimeKind.Utc).AddTicks(308));
        }
    }
}
