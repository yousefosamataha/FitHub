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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleteable",
                table: "gms.Identity.GymIdentityRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsUpdateable",
                table: "gms.Identity.GymIdentityRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 256, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 256, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 281, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 305, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 305, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 305, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 309, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 309, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 310, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 312, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 312, DateTimeKind.Utc).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 10, 13, 25, 7, 313, DateTimeKind.Utc).AddTicks(5392));

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

            migrationBuilder.DropColumn(
                name: "IsDeleteable",
                table: "gms.Identity.GymIdentityRole");

            migrationBuilder.DropColumn(
                name: "IsUpdateable",
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
