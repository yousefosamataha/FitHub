using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.GenderEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BadgeColorId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GenderEnum", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "gms.GenderEnum",
                columns: new[] { "Id", "BadgeColorId", "CreatedAt", "GenderName", "IsDeleted", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, (byte)1, new DateTime(2024, 3, 17, 22, 45, 1, 674, DateTimeKind.Utc).AddTicks(6488), "Male", false, null },
                    { 2, (byte)7, new DateTime(2024, 3, 17, 22, 45, 1, 674, DateTimeKind.Utc).AddTicks(6514), "Female", false, null }
                });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 674, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 674, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 675, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 675, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 675, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 675, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 675, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 675, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 683, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 683, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 683, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 22, 45, 1, 683, DateTimeKind.Utc).AddTicks(5740));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.GenderEnum");

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 268, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 268, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4091));
        }
    }
}
