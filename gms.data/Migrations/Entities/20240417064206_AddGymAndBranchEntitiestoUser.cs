using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class AddGymAndBranchEntitiestoUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.Identity.GymIdentityUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 903, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 903, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 958, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 958, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 958, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 960, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 960, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 963, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 963, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.Gym_GymId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.Gym_GymId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 804, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 804, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 832, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 832, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 832, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 833, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 833, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 836, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 836, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1982));
        }
    }
}
