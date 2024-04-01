using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGymUserEntityToHaveGymEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "4a3e6974-cfaa-4461-9d8d-8e085c4d0236");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "5b92ec3e-b099-4c63-a96e-429fc90ab80f");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "9c4cb3f6-be78-4151-bd52-3ba84b1dea00");

            migrationBuilder.DropColumn(
                name: "GymBranchId",
                table: "gms.Identity.GymUser");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 527, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 527, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.InsertData(
                table: "gms.Identity.GymRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6f90857-745b-4feb-bb7e-515956b386e9", null, "SuperAdmin", "SUPERADMIN" },
                    { "ce36fe07-b3f5-4f46-8133-b71d43a222e2", null, "Admin", "ADMIN" },
                    { "ce814ed9-7546-47ec-bc40-a5595dae320b", null, "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 528, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 529, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 563, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 563, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 563, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 6, 7, 563, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymUser_GymId",
                table: "gms.Identity.GymUser",
                column: "GymId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymUser_gms.Gym_GymId",
                table: "gms.Identity.GymUser",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymUser_gms.Gym_GymId",
                table: "gms.Identity.GymUser");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymUser_GymId",
                table: "gms.Identity.GymUser");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "b6f90857-745b-4feb-bb7e-515956b386e9");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "ce36fe07-b3f5-4f46-8133-b71d43a222e2");

            migrationBuilder.DeleteData(
                table: "gms.Identity.GymRole",
                keyColumn: "Id",
                keyValue: "ce814ed9-7546-47ec-bc40-a5595dae320b");

            migrationBuilder.AddColumn<int>(
                name: "GymBranchId",
                table: "gms.Identity.GymUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 963, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.InsertData(
                table: "gms.Identity.GymRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a3e6974-cfaa-4461-9d8d-8e085c4d0236", null, "Basic", "BASIC" },
                    { "5b92ec3e-b099-4c63-a96e-429fc90ab80f", null, "SuperAdmin", "SUPERADMIN" },
                    { "9c4cb3f6-be78-4151-bd52-3ba84b1dea00", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 964, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 32, 965, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 8, 2, 33, 1, DateTimeKind.Utc).AddTicks(6348));
        }
    }
}
