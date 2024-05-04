using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMigrationV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Gym_gms.GymGeneralSetting_GeneralSettingId",
                table: "gms.Gym");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymBranch_gms.GymGeneralSetting_GeneralSettingId",
                table: "gms.GymBranch");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymBranch_GeneralSettingId",
                table: "gms.GymBranch");

            migrationBuilder.DropIndex(
                name: "IX_gms.Gym_GeneralSettingId",
                table: "gms.Gym");

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

            migrationBuilder.AlterColumn<byte[]>(
                name: "ReportHeader",
                table: "gms.GymGeneralSetting",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ReportFooter",
                table: "gms.GymGeneralSetting",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "GymLogo",
                table: "gms.GymGeneralSetting",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GymId",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GeneralSettingId",
                table: "gms.GymBranch",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "gms.Country",
                columns: new[] { "Id", "CreatedAt", "Currency", "Flag", "IsDeleted", "Language", "ModifiedAt", "Name", "TimeZone" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EGP", new byte[] { 60, 63, 120, 109, 108, 32, 118, 101, 114, 115, 105, 111, 110, 61, 34, 49, 46, 48, 34, 32, 101, 110, 99, 111, 100, 105, 110, 103, 61, 34, 105, 115, 111, 45, 56, 56, 53, 57, 45, 49, 34, 63, 62, 13, 10, 60, 33, 45, 45, 32, 71, 101, 110, 101, 114, 97, 116, 111, 114, 58, 32, 65, 100, 111, 98, 101, 32, 73, 108, 108, 117, 115, 116, 114, 97, 116, 111, 114, 32, 49, 57, 46, 48, 46, 48, 44, 32, 83, 86, 71, 32, 69, 120, 112, 111, 114, 116, 32, 80, 108, 117, 103, 45, 73, 110, 32, 46, 32, 83, 86, 71, 32, 86, 101, 114, 115, 105, 111, 110, 58, 32, 54, 46, 48, 48, 32, 66, 117, 105, 108, 100, 32, 48, 41, 32, 32, 45, 45, 62, 13, 10, 60, 115, 118, 103, 32, 120, 109, 108, 110, 115, 61, 34, 104, 116, 116, 112, 58, 47, 47, 119, 119, 119, 46, 119, 51, 46, 111, 114, 103, 47, 50, 48, 48, 48, 47, 115, 118, 103, 34, 32, 120, 109, 108, 110, 115, 58, 120, 108, 105, 110, 107, 61, 34, 104, 116, 116, 112, 58, 47, 47, 119, 119, 119, 46, 119, 51, 46, 111, 114, 103, 47, 49, 57, 57, 57, 47, 120, 108, 105, 110, 107, 34, 32, 118, 101, 114, 115, 105, 111, 110, 61, 34, 49, 46, 49, 34, 32, 105, 100, 61, 34, 76, 97, 121, 101, 114, 95, 49, 34, 32, 120, 61, 34, 48, 112, 120, 34, 32, 121, 61, 34, 48, 112, 120, 34, 32, 118, 105, 101, 119, 66, 111, 120, 61, 34, 48, 32, 48, 32, 53, 49, 50, 32, 53, 49, 50, 34, 32, 115, 116, 121, 108, 101, 61, 34, 101, 110, 97, 98, 108, 101, 45, 98, 97, 99, 107, 103, 114, 111, 117, 110, 100, 58, 110, 101, 119, 32, 48, 32, 48, 32, 53, 49, 50, 32, 53, 49, 50, 59, 34, 32, 120, 109, 108, 58, 115, 112, 97, 99, 101, 61, 34, 112, 114, 101, 115, 101, 114, 118, 101, 34, 62, 13, 10, 60, 114, 101, 99, 116, 32, 121, 61, 34, 48, 46, 48, 54, 57, 34, 32, 115, 116, 121, 108, 101, 61, 34, 102, 105, 108, 108, 58, 35, 70, 70, 52, 66, 53, 53, 59, 34, 32, 119, 105, 100, 116, 104, 61, 34, 53, 49, 50, 34, 32, 104, 101, 105, 103, 104, 116, 61, 34, 49, 55, 48, 46, 53, 56, 34, 47, 62, 13, 10, 60, 114, 101, 99, 116, 32, 121, 61, 34, 51, 52, 49, 46, 50, 50, 49, 34, 32, 115, 116, 121, 108, 101, 61, 34, 102, 105, 108, 108, 58, 35, 52, 54, 52, 54, 53, 53, 59, 34, 32, 119, 105, 100, 116, 104, 61, 34, 53, 49, 50, 34, 32, 104, 101, 105, 103, 104, 116, 61, 34, 49, 55, 48, 46, 55, 49, 34, 47, 62, 13, 10, 60, 114, 101, 99, 116, 32, 121, 61, 34, 49, 55, 48, 46, 54, 53, 49, 34, 32, 115, 116, 121, 108, 101, 61, 34, 102, 105, 108, 108, 58, 35, 70, 53, 70, 53, 70, 53, 59, 34, 32, 119, 105, 100, 116, 104, 61, 34, 53, 49, 50, 34, 32, 104, 101, 105, 103, 104, 116, 61, 34, 49, 55, 48, 46, 53, 56, 34, 47, 62, 13, 10, 60, 112, 97, 116, 104, 32, 115, 116, 121, 108, 101, 61, 34, 102, 105, 108, 108, 58, 35, 70, 48, 67, 55, 50, 55, 59, 34, 32, 100, 61, 34, 77, 50, 57, 51, 46, 55, 57, 44, 50, 51, 50, 46, 53, 54, 56, 99, 48, 45, 53, 46, 56, 54, 57, 45, 53, 46, 55, 53, 45, 49, 48, 46, 48, 49, 51, 45, 49, 49, 46, 51, 49, 56, 45, 56, 46, 49, 53, 55, 108, 45, 49, 48, 46, 52, 54, 50, 44, 51, 46, 52, 56, 55, 108, 45, 50, 46, 53, 52, 45, 49, 53, 46, 51, 52, 50, 32, 32, 99, 45, 49, 46, 53, 49, 57, 45, 57, 46, 49, 53, 50, 45, 57, 46, 51, 54, 49, 45, 49, 53, 46, 55, 57, 53, 45, 49, 56, 46, 54, 52, 51, 45, 49, 53, 46, 55, 57, 53, 104, 45, 57, 46, 55, 56, 54, 108, 45, 49, 48, 46, 50, 51, 53, 44, 49, 50, 46, 53, 57, 55, 104, 49, 51, 46, 53, 53, 50, 108, 45, 51, 46, 55, 57, 51, 44, 49, 56, 46, 55, 51, 51, 108, 45, 49, 49, 46, 48, 51, 56, 45, 51, 46, 54, 56, 32, 32, 99, 45, 53, 46, 53, 54, 56, 45, 49, 46, 56, 53, 54, 45, 49, 49, 46, 51, 49, 56, 44, 50, 46, 50, 56, 56, 45, 49, 49, 46, 51, 49, 56, 44, 56, 46, 49, 53, 55, 118, 54, 51, 46, 54, 53, 108, 49, 53, 46, 50, 51, 52, 45, 49, 53, 46, 50, 51, 52, 108, 45, 55, 46, 49, 55, 57, 44, 50, 49, 46, 53, 51, 51, 104, 45, 56, 46, 48, 53, 54, 118, 49, 50, 46, 53, 57, 55, 104, 55, 53, 46, 53, 56, 118, 45, 49, 50, 46, 53, 57, 55, 104, 45, 56, 46, 48, 53, 54, 108, 45, 55, 46, 49, 55, 57, 45, 50, 49, 46, 53, 51, 51, 32, 32, 108, 49, 53, 46, 50, 51, 52, 44, 49, 53, 46, 50, 51, 52, 118, 45, 54, 51, 46, 54, 53, 76, 50, 57, 51, 46, 55, 57, 44, 50, 51, 50, 46, 53, 54, 56, 76, 50, 57, 51, 46, 55, 57, 44, 50, 51, 50, 46, 53, 54, 56, 122, 32, 77, 50, 52, 57, 46, 55, 48, 50, 44, 51, 48, 50, 46, 53, 49, 54, 104, 45, 49, 48, 46, 49, 53, 53, 108, 54, 46, 57, 56, 51, 45, 49, 56, 46, 54, 52, 56, 108, 51, 46, 49, 55, 50, 44, 52, 46, 48, 53, 49, 86, 51, 48, 50, 46, 53, 49, 54, 122, 32, 32, 32, 77, 50, 54, 50, 46, 50, 57, 56, 44, 51, 48, 50, 46, 53, 49, 54, 118, 45, 49, 52, 46, 53, 57, 55, 108, 51, 46, 49, 55, 50, 45, 52, 46, 48, 53, 49, 108, 54, 46, 57, 56, 51, 44, 49, 56, 46, 54, 52, 56, 76, 50, 54, 50, 46, 50, 57, 56, 44, 51, 48, 50, 46, 53, 49, 54, 76, 50, 54, 50, 46, 50, 57, 56, 44, 51, 48, 50, 46, 53, 49, 54, 122, 32, 77, 50, 53, 54, 44, 50, 55, 57, 46, 54, 56, 53, 99, 48, 44, 48, 45, 49, 57, 46, 52, 56, 53, 45, 49, 51, 46, 49, 56, 55, 45, 49, 56, 46, 54, 57, 56, 45, 51, 55, 46, 55, 57, 32, 32, 99, 48, 44, 48, 44, 49, 50, 46, 48, 48, 54, 45, 49, 46, 57, 54, 56, 44, 49, 56, 46, 54, 57, 56, 45, 49, 50, 46, 53, 57, 55, 99, 54, 46, 54, 57, 50, 44, 49, 48, 46, 54, 50, 56, 44, 49, 56, 46, 54, 57, 56, 44, 49, 50, 46, 53, 57, 55, 44, 49, 56, 46, 54, 57, 56, 44, 49, 50, 46, 53, 57, 55, 67, 50, 55, 53, 46, 52, 56, 53, 44, 50, 54, 54, 46, 52, 57, 56, 44, 50, 53, 54, 44, 50, 55, 57, 46, 54, 56, 53, 44, 50, 53, 54, 44, 50, 55, 57, 46, 54, 56, 53, 122, 34, 47, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 103, 62, 13, 10, 60, 47, 103, 62, 13, 10, 60, 47, 115, 118, 103, 62, 13, 10 }, false, "ar-EG", null, "Egypt", "" });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 94, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 94, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 115, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 115, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 115, DateTimeKind.Utc).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 115, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 115, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 115, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 115, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 119, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 119, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 119, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 120, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 120, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 121, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 123, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 123, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 123, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 123, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 123, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 47, 7, 123, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymGeneralSetting_BranchId",
                table: "gms.GymGeneralSetting",
                column: "BranchId",
                unique: true,
                filter: "[BranchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymGeneralSetting_GymId",
                table: "gms.GymGeneralSetting",
                column: "GymId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymGeneralSetting_gms.GymBranch_BranchId",
                table: "gms.GymGeneralSetting",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymGeneralSetting_gms.Gym_GymId",
                table: "gms.GymGeneralSetting",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymGeneralSetting_gms.GymBranch_BranchId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymGeneralSetting_gms.Gym_GymId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymGeneralSetting_BranchId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymGeneralSetting_GymId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DeleteData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ReportHeader",
                table: "gms.GymGeneralSetting",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ReportFooter",
                table: "gms.GymGeneralSetting",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "GymLogo",
                table: "gms.GymGeneralSetting",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GymId",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Arms",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Chest",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fat",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReminderDays",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReminderMessage",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Thing",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Waist",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "gms.GymGeneralSetting",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GeneralSettingId",
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
                value: new DateTime(2024, 4, 16, 11, 22, 11, 749, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 749, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 777, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 777, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 777, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 777, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 777, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 777, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 777, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 782, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 782, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 782, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 784, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 787, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 787, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 788, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 788, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 788, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 11, 22, 11, 788, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymBranch_GeneralSettingId",
                table: "gms.GymBranch",
                column: "GeneralSettingId",
                unique: true,
                filter: "[GeneralSettingId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Gym_GeneralSettingId",
                table: "gms.Gym",
                column: "GeneralSettingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Gym_gms.GymGeneralSetting_GeneralSettingId",
                table: "gms.Gym",
                column: "GeneralSettingId",
                principalTable: "gms.GymGeneralSetting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymBranch_gms.GymGeneralSetting_GeneralSettingId",
                table: "gms.GymBranch",
                column: "GeneralSettingId",
                principalTable: "gms.GymGeneralSetting",
                principalColumn: "Id");
        }
    }
}
