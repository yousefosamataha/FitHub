using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateRolesEntityToHaveBranchEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.Identity.GymIdentityRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymIdentityRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymIdentityRole",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.Identity.GymIdentityRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 396, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 396, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 421, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 421, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 421, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 421, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 421, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 421, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 421, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 443, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 443, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 443, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 446, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 446, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 447, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 448, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 448, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 448, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 448, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 448, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 12, 10, 48, 448, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityRole_BranchId",
                table: "gms.Identity.GymIdentityRole",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityRole_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityRole",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityRole_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityRole");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymIdentityRole_BranchId",
                table: "gms.Identity.GymIdentityRole");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.Identity.GymIdentityRole");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 863, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 863, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 884, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.InsertData(
                table: "gms.Identity.GymIdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "SuperAdmin", "SUPERADMIN" },
                    { 2, null, "Admin", "ADMIN" },
                    { 3, null, "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 901, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 901, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 901, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 903, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 903, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 904, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 17, 52, 24, 905, DateTimeKind.Utc).AddTicks(3537));
        }
    }
}
