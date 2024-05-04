using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateGeneralSettingAndGymBranchEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GymLogo",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "GeneralSettingId",
                table: "gms.Gym");

            migrationBuilder.AddColumn<byte[]>(
                name: "GymLogo",
                table: "gms.Gym",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 11, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 11, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 46, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 46, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 46, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 48, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 48, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymBranch_GeneralSettingId",
                table: "gms.GymBranch",
                column: "GeneralSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymBranch_gms.GymGeneralSetting_GeneralSettingId",
                table: "gms.GymBranch",
                column: "GeneralSettingId",
                principalTable: "gms.GymGeneralSetting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymBranch_gms.GymGeneralSetting_GeneralSettingId",
                table: "gms.GymBranch");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymBranch_GeneralSettingId",
                table: "gms.GymBranch");

            migrationBuilder.DropColumn(
                name: "GymLogo",
                table: "gms.Gym");

            migrationBuilder.AddColumn<byte[]>(
                name: "GymLogo",
                table: "gms.GymGeneralSetting",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralSettingId",
                table: "gms.Gym",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 39, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 39, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 88, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 88, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 88, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 90, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 90, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8310));
        }
    }
}
