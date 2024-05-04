using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateGymUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "gms.Identity.GymIdentityUser",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "gms.Identity.GymIdentityUser",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StartYear",
                table: "gms.GymBranch",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 755, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 755, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 784, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 784, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 784, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 784, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 784, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 784, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 784, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 807, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 807, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 807, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 810, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 810, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 811, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 813, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 813, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 813, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 813, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 813, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 17, 8, 41, 813, DateTimeKind.Utc).AddTicks(7640));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "gms.Identity.GymIdentityUser",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "StartYear",
                table: "gms.GymBranch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 207, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 207, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 223, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 223, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 223, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 223, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 223, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 223, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 223, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 237, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 237, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 237, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 239, DateTimeKind.Utc).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 241, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 241, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 241, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 241, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 241, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 21, 42, 33, 241, DateTimeKind.Utc).AddTicks(7564));
        }
    }
}
