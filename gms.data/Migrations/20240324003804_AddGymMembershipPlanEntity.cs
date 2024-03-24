using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations
{
    /// <inheritdoc />
    public partial class AddGymMembershipPlanEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "gms.GymMemberMembership");

            migrationBuilder.RenameColumn(
                name: "MembershipId",
                table: "gms.GymMemberMembership",
                newName: "GymMembershipPlanId");

            migrationBuilder.CreateTable(
                name: "gms.GymMembershipPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipDurationTypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    MembershipAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MembershipStatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    SignupFee = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MembershipDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstallmentPlanId = table.Column<int>(type: "int", nullable: true),
                    InstallmentAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymMembershipPlan", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 579, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 580, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 605, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 605, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 605, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 38, 2, 605, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberMembership_GymMembershipPlanId",
                table: "gms.GymMemberMembership",
                column: "GymMembershipPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymMembershipPlan_GymMembershipPlanId",
                table: "gms.GymMemberMembership",
                column: "GymMembershipPlanId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymMembershipPlan_GymMembershipPlanId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropTable(
                name: "gms.GymMembershipPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymMemberMembership_GymMembershipPlanId",
                table: "gms.GymMemberMembership");

            migrationBuilder.RenameColumn(
                name: "GymMembershipPlanId",
                table: "gms.GymMemberMembership",
                newName: "MembershipId");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "gms.GymMemberMembership",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 359, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 360, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 406, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 406, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 406, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 24, 0, 16, 31, 406, DateTimeKind.Utc).AddTicks(4582));
        }
    }
}
