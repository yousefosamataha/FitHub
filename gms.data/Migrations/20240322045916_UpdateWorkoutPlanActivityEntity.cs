using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWorkoutPlanActivityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "WeekDayId",
                table: "gms.WorkoutPlanActivity",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 704, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 705, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 705, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 711, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 711, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 711, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 59, 12, 711, DateTimeKind.Utc).AddTicks(2994));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeekDayId",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 149, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 149, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 149, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 149, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 149, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 150, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 157, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 157, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 157, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 4, 37, 20, 157, DateTimeKind.Utc).AddTicks(1259));
        }
    }
}
