using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMigrationV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassScheduleDay_gms.ClassSchedule_ClassId",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.StaffClass_gms.ClassSchedule_ClassId",
                table: "gms.StaffClass");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropColumn(
                name: "InstallmentAmount",
                table: "gms.GymMembershipPlan");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "gms.StaffClass",
                newName: "StaffId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.StaffClass_ClassId",
                table: "gms.StaffClass",
                newName: "IX_gms.StaffClass_StaffId");

            migrationBuilder.RenameColumn(
                name: "InstallmentPlanId",
                table: "gms.GymMembershipPlan",
                newName: "GymBranchEntityId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "gms.ClassScheduleDay",
                newName: "ClassScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.ClassScheduleDay_ClassId",
                table: "gms.ClassScheduleDay",
                newName: "IX_gms.ClassScheduleDay_ClassScheduleId");

            migrationBuilder.AddColumn<int>(
                name: "ClassScheduleId",
                table: "gms.StaffClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "gms.Identity.GymIdentityUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GymSpecializationId",
                table: "gms.GymStaffSpecialization",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymStaffId",
                table: "gms.GymStaffSpecialization",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MembershipName",
                table: "gms.GymMembershipPlan",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MembershipDuration",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "ClassIsLimit",
                table: "gms.GymMembershipPlan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ClassLimitDays",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ClassLimitationId",
                table: "gms.GymMembershipPlan",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "gms.GymMembershipPaymentHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymMembershipPaymentHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaidDate",
                table: "gms.GymMembershipPaymentHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GymBranchEntityId",
                table: "gms.GymMemberMembership",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "gms.GymMemberMembership",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "gms.GymGroup",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.ClassSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.ClassLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.ClassLocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "gms.GymMemberGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymMemberUserId = table.Column<int>(type: "int", nullable: false),
                    GymGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymMemberGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymMemberGroup_gms.GymGroup_GymGroupId",
                        column: x => x.GymGroupId,
                        principalTable: "gms.GymGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.GymMemberGroup_gms.Identity.GymIdentityUser_GymMemberUserId",
                        column: x => x.GymMemberUserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.GymMembershipPlanClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipPlanId = table.Column<int>(type: "int", nullable: false),
                    ClassScheduleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymMembershipPlanClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymMembershipPlanClass_gms.ClassSchedule_ClassScheduleId",
                        column: x => x.ClassScheduleId,
                        principalTable: "gms.ClassSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.GymMembershipPlanClass_gms.GymMembershipPlan_MembershipPlanId",
                        column: x => x.MembershipPlanId,
                        principalTable: "gms.GymMembershipPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    BranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymSpecialization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymSpecialization_gms.GymBranch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "gms.GymBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_gms.GymSpecialization_gms.Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "gms.Gym",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.GymStaffGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymStaffUserId = table.Column<int>(type: "int", nullable: false),
                    GymGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymStaffGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymStaffGroup_gms.GymGroup_GymGroupId",
                        column: x => x.GymGroupId,
                        principalTable: "gms.GymGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.GymStaffGroup_gms.Identity.GymIdentityUser_GymStaffUserId",
                        column: x => x.GymStaffUserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.MemberClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymMemberUserId = table.Column<int>(type: "int", nullable: false),
                    ClassScheduleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.MemberClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.MemberClass_gms.ClassSchedule_ClassScheduleId",
                        column: x => x.ClassScheduleId,
                        principalTable: "gms.ClassSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.MemberClass_gms.Identity.GymIdentityUser_GymMemberUserId",
                        column: x => x.GymMemberUserId,
                        principalTable: "gms.Identity.GymIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 208, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 208, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 219, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 219, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 219, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 219, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 219, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 219, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 219, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 223, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 223, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 223, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 225, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 225, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 226, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 228, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 228, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 228, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 228, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 228, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 20, 0, 46, 21, 228, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.CreateIndex(
                name: "IX_gms.StaffClass_ClassScheduleId",
                table: "gms.StaffClass",
                column: "ClassScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymStaffSpecialization_GymSpecializationId",
                table: "gms.GymStaffSpecialization",
                column: "GymSpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymStaffSpecialization_GymStaffId",
                table: "gms.GymStaffSpecialization",
                column: "GymStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMembershipPlan_GymBranchEntityId",
                table: "gms.GymMembershipPlan",
                column: "GymBranchEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberMembership_GymBranchEntityId",
                table: "gms.GymMemberMembership",
                column: "GymBranchEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberMembership_MemberId",
                table: "gms.GymMemberMembership",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_gms.ClassLocation_BranchId",
                table: "gms.ClassLocation",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.ClassLocation_GymId",
                table: "gms.ClassLocation",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberGroup_GymGroupId",
                table: "gms.GymMemberGroup",
                column: "GymGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberGroup_GymMemberUserId",
                table: "gms.GymMemberGroup",
                column: "GymMemberUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMembershipPlanClass_ClassScheduleId",
                table: "gms.GymMembershipPlanClass",
                column: "ClassScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMembershipPlanClass_MembershipPlanId",
                table: "gms.GymMembershipPlanClass",
                column: "MembershipPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymSpecialization_BranchId",
                table: "gms.GymSpecialization",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymSpecialization_GymId",
                table: "gms.GymSpecialization",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymStaffGroup_GymGroupId",
                table: "gms.GymStaffGroup",
                column: "GymGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymStaffGroup_GymStaffUserId",
                table: "gms.GymStaffGroup",
                column: "GymStaffUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.MemberClass_ClassScheduleId",
                table: "gms.MemberClass",
                column: "ClassScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.MemberClass_GymMemberUserId",
                table: "gms.MemberClass",
                column: "GymMemberUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassLocation_gms.GymBranch_BranchId",
                table: "gms.ClassLocation",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassLocation_gms.Gym_GymId",
                table: "gms.ClassLocation",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassScheduleDay_gms.ClassSchedule_ClassScheduleId",
                table: "gms.ClassScheduleDay",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymBranch_GymBranchEntityId",
                table: "gms.GymMemberMembership",
                column: "GymBranchEntityId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberMembership_gms.Identity.GymIdentityUser_MemberId",
                table: "gms.GymMemberMembership",
                column: "MemberId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMembershipPlan_gms.GymBranch_GymBranchEntityId",
                table: "gms.GymMembershipPlan",
                column: "GymBranchEntityId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.GymSpecialization_GymSpecializationId",
                table: "gms.GymStaffSpecialization",
                column: "GymSpecializationId",
                principalTable: "gms.GymSpecialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.Identity.GymIdentityUser_GymStaffId",
                table: "gms.GymStaffSpecialization",
                column: "GymStaffId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.StaffClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.StaffClass",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.StaffClass_gms.Identity.GymIdentityUser_StaffId",
                table: "gms.StaffClass",
                column: "StaffId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassLocation_gms.GymBranch_BranchId",
                table: "gms.ClassLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassLocation_gms.Gym_GymId",
                table: "gms.ClassLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassScheduleDay_gms.ClassSchedule_ClassScheduleId",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymBranch_GymBranchEntityId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.Identity.GymIdentityUser_MemberId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMembershipPlan_gms.GymBranch_GymBranchEntityId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.GymSpecialization_GymSpecializationId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.Identity.GymIdentityUser_GymStaffId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.StaffClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.StaffClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.StaffClass_gms.Identity.GymIdentityUser_StaffId",
                table: "gms.StaffClass");

            migrationBuilder.DropTable(
                name: "gms.GymMemberGroup");

            migrationBuilder.DropTable(
                name: "gms.GymMembershipPlanClass");

            migrationBuilder.DropTable(
                name: "gms.GymSpecialization");

            migrationBuilder.DropTable(
                name: "gms.GymStaffGroup");

            migrationBuilder.DropTable(
                name: "gms.MemberClass");

            migrationBuilder.DropIndex(
                name: "IX_gms.StaffClass_ClassScheduleId",
                table: "gms.StaffClass");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymStaffSpecialization_GymSpecializationId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymStaffSpecialization_GymStaffId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymMembershipPlan_GymBranchEntityId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymMemberMembership_GymBranchEntityId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymMemberMembership_MemberId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropIndex(
                name: "IX_gms.ClassLocation_BranchId",
                table: "gms.ClassLocation");

            migrationBuilder.DropIndex(
                name: "IX_gms.ClassLocation_GymId",
                table: "gms.ClassLocation");

            migrationBuilder.DropColumn(
                name: "ClassScheduleId",
                table: "gms.StaffClass");

            migrationBuilder.DropColumn(
                name: "State",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "GymSpecializationId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropColumn(
                name: "GymStaffId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropColumn(
                name: "ClassIsLimit",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "ClassLimitDays",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "ClassLimitationId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymMembershipPaymentHistory");

            migrationBuilder.DropColumn(
                name: "PaidDate",
                table: "gms.GymMembershipPaymentHistory");

            migrationBuilder.DropColumn(
                name: "GymBranchEntityId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymGroup");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.ClassSchedule");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.ClassLocation");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.ClassLocation");

            migrationBuilder.RenameColumn(
                name: "StaffId",
                table: "gms.StaffClass",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.StaffClass_StaffId",
                table: "gms.StaffClass",
                newName: "IX_gms.StaffClass_ClassId");

            migrationBuilder.RenameColumn(
                name: "GymBranchEntityId",
                table: "gms.GymMembershipPlan",
                newName: "InstallmentPlanId");

            migrationBuilder.RenameColumn(
                name: "ClassScheduleId",
                table: "gms.ClassScheduleDay",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.ClassScheduleDay_ClassScheduleId",
                table: "gms.ClassScheduleDay",
                newName: "IX_gms.ClassScheduleDay_ClassId");

            migrationBuilder.AddColumn<int>(
                name: "GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "gms.GymStaffSpecialization",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MembershipName",
                table: "gms.GymMembershipPlan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "MembershipDuration",
                table: "gms.GymMembershipPlan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "InstallmentAmount",
                table: "gms.GymMembershipPlan",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                table: "gms.GymMembershipPaymentHistory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "gms.GymGroup",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 804, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 804, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 828, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 832, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 832, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 832, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 833, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 833, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 834, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 836, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 836, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 55, 23, 837, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUser_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymStaffSpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassScheduleDay_gms.ClassSchedule_ClassId",
                table: "gms.ClassScheduleDay",
                column: "ClassId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymStaffSpecialization_GymStaffSpecializationId",
                table: "gms.Identity.GymIdentityUser",
                column: "GymStaffSpecializationId",
                principalTable: "gms.GymStaffSpecialization",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.StaffClass_gms.ClassSchedule_ClassId",
                table: "gms.StaffClass",
                column: "ClassId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
