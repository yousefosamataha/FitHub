using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "gms.Identity.GymIdentityUser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 464, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 464, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 486, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 486, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 486, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 486, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 486, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 486, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 486, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 507, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 507, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 507, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 510, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 511, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 511, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 512, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 512, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 512, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 16, 33, 24, 512, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityUser",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "gms.Identity.GymIdentityUser",
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
                value: new DateTime(2024, 4, 25, 14, 6, 13, 489, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 489, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 539, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 539, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 539, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 543, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 543, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 546, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 546, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityUser",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
