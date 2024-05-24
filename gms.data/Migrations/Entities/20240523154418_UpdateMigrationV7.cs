using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMigrationV7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 87, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 87, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 110, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 110, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 110, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 110, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 110, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 110, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 110, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 127, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 127, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 127, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 129, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 129, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SubscriptionStatus" },
                values: new object[] { new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2063), "Suspended" });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.InsertData(
                table: "gms.StatusEnum",
                columns: new[] { "Id", "BadgeColorId", "CreatedAt", "CreatedById", "DeletedAt", "DeletedById", "IsDeleted", "ModifiedAt", "ModifiedById", "SubscriptionStatus" },
                values: new object[] { 9, (byte)5, new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2133), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "OverPaid" });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 131, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 131, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 131, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 131, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 131, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 131, DateTimeKind.Utc).AddTicks(4100));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 256, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 256, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 305, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 305, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 305, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 309, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 309, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SubscriptionStatus" },
                values: new object[] { new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9565), "Suspend" });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 312, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 312, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5392));
        }
    }
}
