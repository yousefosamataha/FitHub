using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateGymIdentityRoleEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "gms.Identity.GymIdentityRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 38, 994, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 38, 994, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 14, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 14, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 14, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 14, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 14, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 14, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 14, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 31, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 31, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 31, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 33, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 35, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 35, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 35, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 35, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 35, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 28, 6, 24, 39, 35, DateTimeKind.Utc).AddTicks(5277));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "gms.Identity.GymIdentityRole");

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
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2063));

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

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 15, 44, 17, 130, DateTimeKind.Utc).AddTicks(2133));

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
    }
}
