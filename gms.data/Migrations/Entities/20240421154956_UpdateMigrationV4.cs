using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMigrationV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassLocation_gms.GymBranch_BranchId",
                table: "gms.ClassLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassLocation_gms.Gym_GymId",
                table: "gms.ClassLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassSchedule_gms.ClassLocation_ClassLocationId",
                table: "gms.ClassSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassScheduleDay_gms.ClassSchedule_ClassScheduleId",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymGeneralSetting_gms.GymBranch_BranchId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymGeneralSetting_gms.Gym_GymId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymGroup_gms.Gym_GymId",
                table: "gms.GymGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberGroup_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymBranch_GymBranchEntityId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymMembershipPlan_GymMembershipPlanId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.Identity.GymIdentityUser_MemberId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMembershipPlan_gms.GymBranch_GymBranchEntityId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMembershipPlanClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMembershipPlanClass_gms.GymMembershipPlan_MembershipPlanId",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymSpecialization_gms.GymBranch_BranchId",
                table: "gms.GymSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymSpecialization_gms.Gym_GymId",
                table: "gms.GymSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffGroup_gms.Identity.GymIdentityUser_GymStaffUserId",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.GymSpecialization_GymSpecializationId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.Identity.GymIdentityUser_GymStaffId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MemberClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.MemberClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MemberClass_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.MemberClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.StaffClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.StaffClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.StaffClass_gms.Identity.GymIdentityUser_StaffId",
                table: "gms.StaffClass");

            migrationBuilder.DropTable(
                name: "gms.GymBranchUsers");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymSpecialization_GymId",
                table: "gms.GymSpecialization");

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
                name: "IX_gms.GymGeneralSetting_BranchId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymGeneralSetting_GymId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropIndex(
                name: "IX_gms.ClassLocation_GymId",
                table: "gms.ClassLocation");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.GymSpecialization");

            migrationBuilder.DropColumn(
                name: "GymBranchEntityId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "gms.ClassLocation");

            migrationBuilder.RenameColumn(
                name: "GymBranchEntityId",
                table: "gms.GymMemberMembership",
                newName: "CreatedById");

            migrationBuilder.RenameColumn(
                name: "GymId",
                table: "gms.GymGroup",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.GymGroup_GymId",
                table: "gms.GymGroup",
                newName: "IX_gms.GymGroup_BranchId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "gms.GymGeneralSetting",
                newName: "CreatedById");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.WorkoutPlanActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.WorkoutPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.SystemSubscription",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.SystemPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.SubscriptionTypeEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.SubscriptionPayment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.StatusEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.StaffClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.PaymentMethodEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.NutritionPlanMeal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.NutritionPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.MembershipActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.MemberLevelEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.MemberClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.MeasurementImage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.MealTime",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.MealIngredient",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.Identity.GymIdentityUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymStaffSpecialization",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymStaffGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "gms.GymSpecialization",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymSpecialization",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymResultMeasurement",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymNotification",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymMembershipPlanClass",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.GymMembershipPaymentHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymMemberGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymMeasurement",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.GymGroup",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymEventReservation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymEventPlace",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GymBranch",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.Gym",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.GenderEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.ClassScheduleDay",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.ClassSchedule",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.ClassSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "gms.ClassLocation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.ClassLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.ActivityVideo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.ActivityCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "gms.Activity",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedById",
                value: null);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 971, DateTimeKind.Utc).AddTicks(999), null });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 971, DateTimeKind.Utc).AddTicks(1009), null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1521), null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1529), null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1532), null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1534), null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1537), null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1541), null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1543), null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 990, DateTimeKind.Utc).AddTicks(1564), null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 990, DateTimeKind.Utc).AddTicks(1579), null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 990, DateTimeKind.Utc).AddTicks(1584), null });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 992, DateTimeKind.Utc).AddTicks(5242), null });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 992, DateTimeKind.Utc).AddTicks(5256), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3964), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3972), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3975), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3977), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3980), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3984), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3987), null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3994), null });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(5591), null });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(5622), null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9834), null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9846), null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9850), null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9854), null });

            migrationBuilder.CreateIndex(
                name: "IX_gms.Identity.GymIdentityUser_BranchId",
                table: "gms.Identity.GymIdentityUser",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMembershipPlan_BranchId",
                table: "gms.GymMembershipPlan",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMemberMembership_MemberId",
                table: "gms.GymMemberMembership",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.ClassSchedule_BranchId",
                table: "gms.ClassSchedule",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassLocation_gms.GymBranch_BranchId",
                table: "gms.ClassLocation",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassSchedule_gms.ClassLocation_ClassLocationId",
                table: "gms.ClassSchedule",
                column: "ClassLocationId",
                principalTable: "gms.ClassLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassSchedule_gms.GymBranch_BranchId",
                table: "gms.ClassSchedule",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassScheduleDay_gms.ClassSchedule_ClassScheduleId",
                table: "gms.ClassScheduleDay",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymGroup_gms.GymBranch_BranchId",
                table: "gms.GymGroup",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymMemberGroup",
                column: "GymGroupId",
                principalTable: "gms.GymGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberGroup_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.GymMemberGroup",
                column: "GymMemberUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymMembershipPlan_GymMembershipPlanId",
                table: "gms.GymMemberMembership",
                column: "GymMembershipPlanId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberMembership_gms.Identity.GymIdentityUser_MemberId",
                table: "gms.GymMemberMembership",
                column: "MemberId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMembershipPlan_gms.GymBranch_BranchId",
                table: "gms.GymMembershipPlan",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMembershipPlanClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.GymMembershipPlanClass",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMembershipPlanClass_gms.GymMembershipPlan_MembershipPlanId",
                table: "gms.GymMembershipPlanClass",
                column: "MembershipPlanId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymSpecialization_gms.GymBranch_BranchId",
                table: "gms.GymSpecialization",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymStaffGroup",
                column: "GymGroupId",
                principalTable: "gms.GymGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffGroup_gms.Identity.GymIdentityUser_GymStaffUserId",
                table: "gms.GymStaffGroup",
                column: "GymStaffUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.GymSpecialization_GymSpecializationId",
                table: "gms.GymStaffSpecialization",
                column: "GymSpecializationId",
                principalTable: "gms.GymSpecialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.Identity.GymIdentityUser_GymStaffId",
                table: "gms.GymStaffSpecialization",
                column: "GymStaffId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityUser",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MemberClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.MemberClass",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MemberClass_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.MemberClass",
                column: "GymMemberUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.StaffClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.StaffClass",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.StaffClass_gms.Identity.GymIdentityUser_StaffId",
                table: "gms.StaffClass",
                column: "StaffId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassLocation_gms.GymBranch_BranchId",
                table: "gms.ClassLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassSchedule_gms.ClassLocation_ClassLocationId",
                table: "gms.ClassSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassSchedule_gms.GymBranch_BranchId",
                table: "gms.ClassSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassScheduleDay_gms.ClassSchedule_ClassScheduleId",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymGroup_gms.GymBranch_BranchId",
                table: "gms.GymGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberGroup_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymMembershipPlan_GymMembershipPlanId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMemberMembership_gms.Identity.GymIdentityUser_MemberId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMembershipPlan_gms.GymBranch_BranchId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMembershipPlanClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMembershipPlanClass_gms.GymMembershipPlan_MembershipPlanId",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymSpecialization_gms.GymBranch_BranchId",
                table: "gms.GymSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffGroup_gms.Identity.GymIdentityUser_GymStaffUserId",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.GymSpecialization_GymSpecializationId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymStaffSpecialization_gms.Identity.GymIdentityUser_GymStaffId",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.Identity.GymIdentityUser_gms.GymBranch_BranchId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MemberClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.MemberClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MemberClass_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.MemberClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.StaffClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.StaffClass");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.StaffClass_gms.Identity.GymIdentityUser_StaffId",
                table: "gms.StaffClass");

            migrationBuilder.DropIndex(
                name: "IX_gms.Identity.GymIdentityUser_BranchId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymMembershipPlan_BranchId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymMemberMembership_MemberId",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropIndex(
                name: "IX_gms.ClassSchedule_BranchId",
                table: "gms.ClassSchedule");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.SystemPlan");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.SubscriptionTypeEnum");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.StatusEnum");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.StaffClass");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.PaymentMethodEnum");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.MembershipActivity");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.MemberLevelEnum");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.MemberClass");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.MeasurementImage");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.MealTime");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.MealIngredient");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.Identity.GymIdentityUser");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymSpecialization");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymResultMeasurement");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymNotification");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymMeasurement");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymEventReservation");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymEventPlace");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GymBranch");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.Gym");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.GenderEnum");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.Country");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.ClassSchedule");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.ClassLocation");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.ActivityVideo");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.ActivityCategory");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "gms.Activity");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "gms.GymMemberMembership",
                newName: "GymBranchEntityId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "gms.GymGroup",
                newName: "GymId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.GymGroup_BranchId",
                table: "gms.GymGroup",
                newName: "IX_gms.GymGroup_GymId");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "gms.GymGeneralSetting",
                newName: "BranchId");

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "gms.GymSpecialization",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.GymSpecialization",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GymBranchEntityId",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.GymMembershipPaymentHistory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.GymGroup",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedById",
                table: "gms.ClassSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BranchId",
                table: "gms.ClassLocation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "gms.ClassLocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "gms.GymBranchUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymBranchId = table.Column<int>(type: "int", nullable: false),
                    GymUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymBranchUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymBranchUsers_gms.GymBranch_GymBranchId",
                        column: x => x.GymBranchId,
                        principalTable: "gms.GymBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_gms.GymBranchUsers_gms.Identity.GymIdentityUser_GymUserId",
                        column: x => x.GymUserId,
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
                name: "IX_gms.GymSpecialization_GymId",
                table: "gms.GymSpecialization",
                column: "GymId");

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
                name: "IX_gms.GymGeneralSetting_BranchId",
                table: "gms.GymGeneralSetting",
                column: "BranchId",
                unique: true,
                filter: "[BranchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymGeneralSetting_GymId",
                table: "gms.GymGeneralSetting",
                column: "GymId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_gms.ClassLocation_GymId",
                table: "gms.ClassLocation",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymBranchUsers_GymBranchId",
                table: "gms.GymBranchUsers",
                column: "GymBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymBranchUsers_GymUserId",
                table: "gms.GymBranchUsers",
                column: "GymUserId");

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
                name: "FK_gms.ClassSchedule_gms.ClassLocation_ClassLocationId",
                table: "gms.ClassSchedule",
                column: "ClassLocationId",
                principalTable: "gms.ClassLocation",
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
                name: "FK_gms.GymGeneralSetting_gms.GymBranch_BranchId",
                table: "gms.GymGeneralSetting",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymGeneralSetting_gms.Gym_GymId",
                table: "gms.GymGeneralSetting",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymGroup_gms.Gym_GymId",
                table: "gms.GymGroup",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymMemberGroup",
                column: "GymGroupId",
                principalTable: "gms.GymGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberGroup_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.GymMemberGroup",
                column: "GymMemberUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymBranch_GymBranchEntityId",
                table: "gms.GymMemberMembership",
                column: "GymBranchEntityId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMemberMembership_gms.GymMembershipPlan_GymMembershipPlanId",
                table: "gms.GymMemberMembership",
                column: "GymMembershipPlanId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_gms.GymMembershipPlanClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.GymMembershipPlanClass",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMembershipPlanClass_gms.GymMembershipPlan_MembershipPlanId",
                table: "gms.GymMembershipPlanClass",
                column: "MembershipPlanId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymSpecialization_gms.GymBranch_BranchId",
                table: "gms.GymSpecialization",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymSpecialization_gms.Gym_GymId",
                table: "gms.GymSpecialization",
                column: "GymId",
                principalTable: "gms.Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffGroup_gms.GymGroup_GymGroupId",
                table: "gms.GymStaffGroup",
                column: "GymGroupId",
                principalTable: "gms.GymGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymStaffGroup_gms.Identity.GymIdentityUser_GymStaffUserId",
                table: "gms.GymStaffGroup",
                column: "GymStaffUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_gms.MemberClass_gms.ClassSchedule_ClassScheduleId",
                table: "gms.MemberClass",
                column: "ClassScheduleId",
                principalTable: "gms.ClassSchedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MemberClass_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.MemberClass",
                column: "GymMemberUserId",
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
    }
}
