using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentMethodEnum : Migration
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
                    { 1, new DateTime(2024, 3, 2, 10, 26, 3, 706, DateTimeKind.Utc).AddTicks(8867), false, null, "Cash" },
                    { 2, new DateTime(2024, 3, 2, 10, 26, 3, 706, DateTimeKind.Utc).AddTicks(8876), false, null, "Credit" }
                });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 26, 3, 707, DateTimeKind.Utc).AddTicks(9016));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.PaymentMethodEnum");

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6379));
        }
    }
}
