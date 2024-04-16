using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateGymUserToAddRealationForGymStaffSecialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 883, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 883, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 924, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 924, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 924, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 924, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 924, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 924, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 924, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 960, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 960, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 960, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 962, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 962, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 967, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 972, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 972, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 973, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 973, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 973, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 53, 973, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymStaffSpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymStaffSpecializationId",
                principalTable: "gms.GymStaffSpecialization",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 408, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 408, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 437, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 437, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 437, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 438, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 438, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8682));
        }
    }
}
