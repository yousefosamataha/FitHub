using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGymBranchEntityToHaveRelationWithCountry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "gms.GymBranch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 553, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 555, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 555, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 555, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 32, 6, 555, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymBranch_CountryId",
                table: "gms.GymBranch",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymBranch_gms.Country_CountryId",
                table: "gms.GymBranch",
                column: "CountryId",
                principalTable: "gms.Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymBranch_gms.Country_CountryId",
                table: "gms.GymBranch");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymBranch_CountryId",
                table: "gms.GymBranch");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "gms.GymBranch");

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 761, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 761, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 761, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 761, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 761, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionStatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 761, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 762, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 762, DateTimeKind.Utc).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 763, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 763, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 763, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 16, 23, 28, 48, 763, DateTimeKind.Utc).AddTicks(6321));
        }
    }
}
