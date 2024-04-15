using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class AddGymResultMeasurementEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.GymResultMeasurement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymResultMeasurement", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.InsertData(
                table: "gms.GymResultMeasurement",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8128), false, null, "Weight" },
                    { 2, new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8133), false, null, "Height" },
                    { 3, new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8135), false, null, "Chest" },
                    { 4, new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8137), false, null, "Waist" },
                    { 5, new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8138), false, null, "Thing" },
                    { 6, new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8141), false, null, "Arms" },
                    { 7, new DateTime(2024, 3, 22, 5, 44, 44, 676, DateTimeKind.Utc).AddTicks(8143), false, null, "Fat" }
                });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 677, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 44, 44, 683, DateTimeKind.Utc).AddTicks(1125));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.GymResultMeasurement");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 114, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 114, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 115, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 121, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 121, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 121, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 5, 26, 48, 121, DateTimeKind.Utc).AddTicks(7573));
        }
    }
}
