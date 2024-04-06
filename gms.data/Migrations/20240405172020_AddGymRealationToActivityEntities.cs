using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGymRealationToActivityEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.ActivityCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 189, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 190, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 246, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 246, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 246, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 20, 19, 246, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.CreateIndex(
                name: "IX_gms.ActivityCategory_GymId",
                table: "gms.ActivityCategory",
                column: "GymId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ActivityCategory_gms.Gym_GymId",
                table: "gms.ActivityCategory",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ActivityCategory_gms.Gym_GymId",
                table: "gms.ActivityCategory");

            migrationBuilder.DropIndex(
                name: "IX_gms.ActivityCategory_GymId",
                table: "gms.ActivityCategory");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.ActivityCategory");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 121, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 121, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 122, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 123, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 160, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 160, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 160, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 17, 1, 2, 160, DateTimeKind.Utc).AddTicks(3054));
        }
    }
}
