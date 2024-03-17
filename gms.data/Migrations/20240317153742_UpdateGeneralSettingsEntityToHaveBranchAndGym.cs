using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGeneralSettingsEntityToHaveBranchAndGym : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralSettingId",
                table: "gms.GymBranch",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralSettingId",
                table: "gms.Gym",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 267, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 268, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 268, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 37, 41, 276, DateTimeKind.Utc).AddTicks(4091));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "BranchId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "GeneralSettingId",
                table: "gms.GymBranch");

            migrationBuilder.DropColumn(
                name: "GeneralSettingId",
                table: "gms.Gym");

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 736, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 736, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 736, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 736, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 736, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 736, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 737, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 737, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 738, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 738, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 738, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 17, 15, 14, 12, 738, DateTimeKind.Utc).AddTicks(6091));
        }
    }
}
