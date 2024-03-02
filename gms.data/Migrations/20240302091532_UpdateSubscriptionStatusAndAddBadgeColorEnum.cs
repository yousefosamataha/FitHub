using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSubscriptionStatusAndAddBadgeColorEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "BadgeColorId",
                table: "gms.SubscriptionStatusEnum",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BadgeColorId", "CreatedAt" },
                values: new object[] { (byte)2, new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BadgeColorId", "CreatedAt" },
                values: new object[] { (byte)4, new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BadgeColorId", "CreatedAt" },
                values: new object[] { (byte)6, new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BadgeColorId", "CreatedAt" },
                values: new object[] { (byte)3, new DateTime(2024, 3, 2, 9, 15, 31, 890, DateTimeKind.Utc).AddTicks(778) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BadgeColorId",
                table: "gms.SubscriptionStatusEnum");

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 2, 8, 45, 9, 534, DateTimeKind.Utc).AddTicks(3840));
        }
    }
}
