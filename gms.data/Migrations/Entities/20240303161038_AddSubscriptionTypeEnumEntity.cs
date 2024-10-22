﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations.Entities
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

            migrationBuilder.InsertData(
                table: "gms.SubscriptionTypeEnum",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 3, 16, 10, 37, 112, DateTimeKind.Utc).AddTicks(301), false, null, "Monthly" },
                    { 2, new DateTime(2024, 3, 3, 16, 10, 37, 112, DateTimeKind.Utc).AddTicks(308), false, null, "Annually" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SubscriptionTypeEnum");

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 8, 50, 417, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 3, 16, 8, 50, 417, DateTimeKind.Utc).AddTicks(4476));
        }
    }
}
