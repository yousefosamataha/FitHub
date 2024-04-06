using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
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
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 73, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 74, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 74, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 81, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 81, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 81, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 11, 11, 81, DateTimeKind.Utc).AddTicks(9366));

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
                value: new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 417, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 417, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 417, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 417, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 417, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 417, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 425, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 425, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 425, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 0, 8, 12, 425, DateTimeKind.Utc).AddTicks(744));

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
