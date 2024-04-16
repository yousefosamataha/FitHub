using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class AddGymStaffSpecializationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gms.GymStaffSpecialization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymStaffSpecialization", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 408, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 408, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 433, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 437, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 437, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 437, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 438, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 438, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 439, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 56, 25, 441, DateTimeKind.Utc).AddTicks(8682));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.GymStaffSpecialization");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 201, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 201, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 226, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 231, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 231, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 231, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 233, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 233, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 234, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 55, 11, 236, DateTimeKind.Utc).AddTicks(9697));
        }
    }
}
