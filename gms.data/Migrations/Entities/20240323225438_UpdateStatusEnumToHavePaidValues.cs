using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateStatusEnumToHavePaidValues : Migration
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
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 190, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.InsertData(
                table: "gms.StatusEnum",
                columns: new[] { "Id", "BadgeColorId", "CreatedAt", "IsDeleted", "ModifiedAt", "SubscriptionStatus" },
                values: new object[,]
                {
                    { 1, (byte)2, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3217), false, null, "Active" },
                    { 2, (byte)3, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3226), false, null, "InActive" },
                    { 3, (byte)4, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3228), false, null, "Suspend" },
                    { 4, (byte)6, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3231), false, null, "Cancelled" },
                    { 5, (byte)3, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3234), false, null, "Expired" },
                    { 6, (byte)3, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3238), false, null, "NotPaid" },
                    { 7, (byte)4, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3241), false, null, "PartiallyPaid" },
                    { 8, (byte)2, new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(3243), false, null, "FullyPaid" }
                });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 191, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 201, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 201, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 201, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 23, 22, 54, 37, 201, DateTimeKind.Utc).AddTicks(7049));
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
