using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddMemberLevelEnumEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.MemberLevelEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LevelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.MemberLevelEnum", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "gms.MemberLevelEnum",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "LevelName", "ModifiedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(7445), false, "Beginner", null },
                    { 2, new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(7451), false, "Intermediate", null },
                    { 3, new DateTime(2024, 3, 22, 0, 8, 12, 416, DateTimeKind.Utc).AddTicks(7453), false, "Advanced", null }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.MemberLevelEnum");

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
        }
    }
}
