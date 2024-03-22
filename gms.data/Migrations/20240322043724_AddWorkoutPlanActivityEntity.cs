using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkoutPlanActivityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.WorkoutPlanActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Kg = table.Column<double>(type: "float", nullable: false),
                    RestTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.WorkoutPlanActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.WorkoutPlanActivity_gms.Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "gms.Activity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.WorkoutPlanActivity_gms.WorkoutPlan_WorkoutPlanId",
                        column: x => x.WorkoutPlanId,
                        principalTable: "gms.WorkoutPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_gms.WorkoutPlanActivity_ActivityId",
                table: "gms.WorkoutPlanActivity",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.WorkoutPlanActivity_WorkoutPlanId",
                table: "gms.WorkoutPlanActivity",
                column: "WorkoutPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.WorkoutPlanActivity");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 280, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 280, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 280, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 280, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 280, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 281, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 289, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 289, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 289, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 22, 1, 7, 42, 289, DateTimeKind.Utc).AddTicks(5159));
        }
    }
}
