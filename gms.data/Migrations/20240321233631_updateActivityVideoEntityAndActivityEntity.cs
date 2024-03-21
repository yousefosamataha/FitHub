using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class updateActivityVideoEntityAndActivityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ActivityVideo_gms.Activity_ActivityEntityId",
                table: "gms.ActivityVideo");

            migrationBuilder.DropIndex(
                name: "IX_gms.ActivityVideo_ActivityEntityId",
                table: "gms.ActivityVideo");

            migrationBuilder.DropColumn(
                name: "ActivityEntityId",
                table: "gms.ActivityVideo");

            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "gms.ActivityVideo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 336, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 337, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 337, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 344, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 344, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 344, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 23, 36, 30, 344, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.CreateIndex(
                name: "IX_gms.ActivityVideo_ActivityId",
                table: "gms.ActivityVideo",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ActivityVideo_gms.Activity_ActivityId",
                table: "gms.ActivityVideo",
                column: "ActivityId",
                principalTable: "gms.Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ActivityVideo_gms.Activity_ActivityId",
                table: "gms.ActivityVideo");

            migrationBuilder.DropIndex(
                name: "IX_gms.ActivityVideo_ActivityId",
                table: "gms.ActivityVideo");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "gms.ActivityVideo");

            migrationBuilder.AddColumn<int>(
                name: "ActivityEntityId",
                table: "gms.ActivityVideo",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 633, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 634, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 634, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 642, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 642, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 642, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 0, 23, 38, 642, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.CreateIndex(
                name: "IX_gms.ActivityVideo_ActivityEntityId",
                table: "gms.ActivityVideo",
                column: "ActivityEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ActivityVideo_gms.Activity_ActivityEntityId",
                table: "gms.ActivityVideo",
                column: "ActivityEntityId",
                principalTable: "gms.Activity",
                principalColumn: "Id");
        }
    }
}
