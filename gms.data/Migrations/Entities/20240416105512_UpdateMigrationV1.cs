using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMigrationV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.SubscriptionPayment_gms.SystemSubscription_SubscriptionId",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropIndex(
                name: "IX_gms.SubscriptionPayment_SubscriptionId",
                table: "gms.SubscriptionPayment");

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.SystemSubscription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PlanName",
                table: "gms.SystemPlan",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "gms.SubscriptionPayment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 201, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 201, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 231, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 231, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 231, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 233, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 233, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.CreateIndex(
                name: "IX_gms.SystemSubscription_GymId",
                table: "gms.SystemSubscription",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.SystemSubscription_SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                column: "SubscriptionPaymentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.SystemSubscription_gms.Gym_GymId",
                table: "gms.SystemSubscription",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.SystemSubscription_gms.SubscriptionPayment_SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                column: "SubscriptionPaymentId",
                principalTable: "gms.SubscriptionPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.SystemSubscription_gms.Gym_GymId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.SystemSubscription_gms.SubscriptionPayment_SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropIndex(
                name: "IX_gms.SystemSubscription_GymId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropIndex(
                name: "IX_gms.SystemSubscription_SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.AlterColumn<string>(
                name: "PlanName",
                table: "gms.SystemPlan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "gms.SubscriptionPayment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 510, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 510, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 544, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 544, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 544, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 544, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 544, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 544, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 544, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 569, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 569, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 569, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 571, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 571, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 573, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 574, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 574, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 572, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 572, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 572, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 26, 28, 572, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.CreateIndex(
                name: "IX_gms.SubscriptionPayment_SubscriptionId",
                table: "gms.SubscriptionPayment",
                column: "SubscriptionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.SubscriptionPayment_gms.SystemSubscription_SubscriptionId",
                table: "gms.SubscriptionPayment",
                column: "SubscriptionId",
                principalTable: "gms.SystemSubscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
