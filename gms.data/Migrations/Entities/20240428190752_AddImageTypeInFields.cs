using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class AddImageTypeInFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlagType",
                table: "gms.Country");

            migrationBuilder.AddColumn<byte>(
                name: "ImageTypeId",
                table: "gms.MeasurementImage",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "ImageTypeId",
                table: "gms.Identity.GymIdentityUser",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ImageTypeId",
                table: "gms.GymGroup",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ReportFooterTypeId",
                table: "gms.GymGeneralSetting",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ReportHeaderTypeId",
                table: "gms.GymGeneralSetting",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "GymLogoTypeId",
                table: "gms.Gym",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "FlagTypeId",
                table: "gms.Country",
                type: "tinyint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "FlagTypeId",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 280, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 280, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 307, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 333, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 333, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 333, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 337, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 337, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 338, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 19, 7, 50, 339, DateTimeKind.Utc).AddTicks(8631));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageTypeId",
                table: "gms.MeasurementImage");

            migrationBuilder.DropColumn(
                name: "ImageTypeId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "ImageTypeId",
                table: "gms.GymGroup");

            migrationBuilder.DropColumn(
                name: "ReportFooterTypeId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "ReportHeaderTypeId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "GymLogoTypeId",
                table: "gms.Gym");

            migrationBuilder.DropColumn(
                name: "FlagTypeId",
                table: "gms.Country");

            migrationBuilder.AddColumn<string>(
                name: "FlagType",
                table: "gms.Country",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 2,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 3,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 4,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 5,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 6,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 7,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 8,
                column: "FlagType",
                value: "data:image/svg+xml;base64,");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 11, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 11, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 29, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 46, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 46, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 46, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 48, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 48, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 49, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 23, 18, 49, 50, DateTimeKind.Utc).AddTicks(5292));
        }
    }
}
