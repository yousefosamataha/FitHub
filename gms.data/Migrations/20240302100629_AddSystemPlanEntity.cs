using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddSystemPlanEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.SystemPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReminderDays = table.Column<int>(type: "int", nullable: false),
                    PricePerMonth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerYear = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxBranchNumber = table.Column<int>(type: "int", nullable: false),
                    MaxStaffNumberPerBranch = table.Column<int>(type: "int", nullable: false),
                    MaxMemberNumberPerBranch = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.SystemPlan", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.InsertData(
                table: "gms.SystemPlan",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "MaxBranchNumber", "MaxMemberNumberPerBranch", "MaxStaffNumberPerBranch", "ModifiedAt", "PlanName", "PricePerMonth", "PricePerYear", "ReminderDays" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6365), false, 1, 50, 20, null, "free_trial", 0m, 0m, 0 },
                    { 2, new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6375), false, 3, 100, 30, null, "startup", 500m, 5000m, 10 },
                    { 3, new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6377), false, 5, 200, 40, null, "business", 1000m, 10000m, 10 },
                    { 4, new DateTime(2024, 3, 2, 10, 6, 28, 277, DateTimeKind.Utc).AddTicks(6379), false, 10, 400, 50, null, "enterprise", 2000m, 20000m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.SystemPlan");

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(2645));
        }
    }
}
