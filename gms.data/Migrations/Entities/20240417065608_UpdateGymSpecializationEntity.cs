using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateGymSpecializationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropTable(
                name: "gms.GymStaffSpecialization");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.CreateTable(
                name: "gms.GymSpecialization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    GymBranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymSpecialization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymSpecialization_gms.GymBranch_GymBranchId",
                        column: x => x.GymBranchId,
                        principalTable: "gms.GymBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.GymSpecialization_gms.Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "gms.Gym",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 855, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 855, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 876, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 876, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 876, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 876, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 876, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 876, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 876, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 879, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 879, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 879, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 880, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 880, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 881, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 883, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 883, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 883, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 883, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 883, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 56, 6, 883, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymSpecialization_GymBranchId",
                table: "gms.GymSpecialization",
                column: "GymBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymSpecialization_GymId",
                table: "gms.GymSpecialization",
                column: "GymId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gms.GymSpecialization");

            migrationBuilder.AddColumn<int>(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "gms.GymStaffSpecialization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
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
                value: new DateTime(2024, 4, 17, 6, 42, 4, 903, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 903, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 953, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 958, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 958, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 958, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 960, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 960, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 961, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 963, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 963, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 6, 42, 4, 964, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymStaffSpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymStaffSpecializationId",
                principalTable: "gms.GymStaffSpecialization",
                principalColumn: "Id");
        }
    }
}
