using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatusEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SubscriptionStatusEnum");

            migrationBuilder.CreateTable(
                name: "gms.StatusEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SubscriptionStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BadgeColorId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.StatusEnum", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 820, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.InsertData(
                table: "gms.StatusEnum",
                columns: new[] { "Id", "BadgeColorId", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionStatus" },
                values: new object[,]
                {
                    { 1, (byte)2, new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(6832), false, null, "Active" },
                    { 2, (byte)3, new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(6838), false, null, "InActive" },
                    { 3, (byte)4, new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(6841), false, null, "Suspend" },
                    { 4, (byte)6, new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(6843), false, null, "Cancelled" },
                    { 5, (byte)3, new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(6845), false, null, "Expired" }
                });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 821, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 829, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 829, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 829, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 45, 45, 829, DateTimeKind.Utc).AddTicks(9478));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.StatusEnum");

            migrationBuilder.CreateTable(
                name: "gms.SubscriptionStatusEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BadgeColorId = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubscriptionStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.SubscriptionStatusEnum", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 361, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.InsertData(
                table: "gms.SubscriptionStatusEnum",
                columns: new[] { "Id", "BadgeColorId", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionStatus" },
                values: new object[,]
                {
                    { 1, (byte)2, new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1451), false, null, "Active" },
                    { 2, (byte)4, new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1496), false, null, "Suspend" },
                    { 3, (byte)6, new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1499), false, null, "Cancelled" },
                    { 4, (byte)3, new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(1501), false, null, "Expired" }
                });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 362, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 6, 3, 31, 368, DateTimeKind.Utc).AddTicks(8614));
        }
    }
}
