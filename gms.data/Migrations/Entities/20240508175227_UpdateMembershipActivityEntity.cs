using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMembershipActivityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.MembershipActivity_gms.GymMembershipPlan_ActivityId",
                table: "gms.MembershipActivity");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 863, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 863, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 901, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 901, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 901, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 903, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 903, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.CreateIndex(
                name: "IX_gms.MembershipActivity_MembershipPlanId",
                table: "gms.MembershipActivity",
                column: "MembershipPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MembershipActivity_gms.GymMembershipPlan_MembershipPlanId",
                table: "gms.MembershipActivity",
                column: "MembershipPlanId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.MembershipActivity_gms.GymMembershipPlan_MembershipPlanId",
                table: "gms.MembershipActivity");

            migrationBuilder.DropIndex(
                name: "IX_gms.MembershipActivity_MembershipPlanId",
                table: "gms.MembershipActivity");

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

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MembershipActivity_gms.GymMembershipPlan_ActivityId",
                table: "gms.MembershipActivity",
                column: "ActivityId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
