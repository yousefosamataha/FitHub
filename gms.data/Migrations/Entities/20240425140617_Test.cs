using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateSubscriptionPaymentAndSystemSubscriptionEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.SystemSubscription_gms.SubscriptionPayment_SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropIndex(
                name: "IX_gms.SystemSubscription_SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 267, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 267, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 287, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 287, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 287, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 287, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 287, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 287, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 287, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 303, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 303, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 303, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 305, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 305, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 306, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 307, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 307, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 307, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 307, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 307, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 26, 15, 15, 52, 307, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.CreateIndex(
                name: "IX_gms.SubscriptionPayment_SubscriptionId",
                table: "gms.SubscriptionPayment",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.SubscriptionPayment_gms.SystemSubscription_SubscriptionId",
                table: "gms.SubscriptionPayment",
                column: "SubscriptionId",
                principalTable: "gms.SystemSubscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.SubscriptionPayment_gms.SystemSubscription_SubscriptionId",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropIndex(
                name: "IX_gms.SubscriptionPayment_SubscriptionId",
                table: "gms.SubscriptionPayment");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 321, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 321, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 376, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 376, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 376, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 380, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 380, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.CreateIndex(
                name: "IX_gms.SystemSubscription_SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                column: "SubscriptionPaymentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.SystemSubscription_gms.SubscriptionPayment_SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                column: "SubscriptionPaymentId",
                principalTable: "gms.SubscriptionPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
