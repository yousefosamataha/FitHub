using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateGymGeneralSettingEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "GymUserTypeId",
                table: "gms.Identity.GymIdentityUser",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)3,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)2);

            migrationBuilder.AddColumn<string>(
                name: "Arms",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Inches");

            migrationBuilder.AddColumn<string>(
                name: "Chest",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Inches");

            migrationBuilder.AddColumn<string>(
                name: "Fat",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Percentage");

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Centimeter");

            migrationBuilder.AddColumn<int>(
                name: "ReminderDays",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: false,
                defaultValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "ReminderMessage",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Hello {0},\r\n      Your Membership  {1}  started at {2} and it will expire on {3}.\r\nThank You.");

            migrationBuilder.AddColumn<string>(
                name: "Thing",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Inches");

            migrationBuilder.AddColumn<string>(
                name: "Waist",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Inches");

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "KG");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 13, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 13, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 34, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 34, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 34, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 34, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 34, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 34, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 34, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 52, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 52, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 52, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 54, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 54, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 55, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 56, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 56, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 56, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 56, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 56, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 4, 18, 22, 51, 56, DateTimeKind.Utc).AddTicks(5191));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arms",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "Chest",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "Fat",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "ReminderDays",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "ReminderMessage",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "Thing",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "Waist",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "gms.GymGeneralSetting");

            migrationBuilder.AlterColumn<byte>(
                name: "GymUserTypeId",
                table: "gms.Identity.GymIdentityUser",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)2,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)3);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 280, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 280, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 333, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 333, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 333, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 337, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 337, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8631));
        }
    }
}
