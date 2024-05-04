using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMigrationV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Activity_gms.ActivityCategory_ActivityCategoryId",
                table: "gms.Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MembershipActivity_gms.Activity_ActivityId",
                table: "gms.MembershipActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.Activity_ActivityId",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.WorkoutPlan_WorkoutPlanId",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.AddColumn<int>(
                name: "AssignedByGymStaffUserId",
                table: "gms.WorkoutPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.WorkoutPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymMemberUserId",
                table: "gms.WorkoutPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "WorkoutPlanStatusId",
                table: "gms.WorkoutPlan",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "MembershipPlanId",
                table: "gms.MembershipActivity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.ActivityCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 779, DateTimeKind.Utc).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 779, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 797, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 797, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 797, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 797, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 797, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 797, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 797, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 811, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 811, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 811, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 814, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 814, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 815, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 816, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 816, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 817, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 817, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 817, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 21, 10, 15, 817, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.CreateIndex(
                name: "IX_gms.WorkoutPlan_AssignedByGymStaffUserId",
                table: "gms.WorkoutPlan",
                column: "AssignedByGymStaffUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.WorkoutPlan_BranchId",
                table: "gms.WorkoutPlan",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.WorkoutPlan_GymMemberUserId",
                table: "gms.WorkoutPlan",
                column: "GymMemberUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.ActivityCategory_BranchId",
                table: "gms.ActivityCategory",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.Activity_BranchId",
                table: "gms.Activity",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Activity_gms.ActivityCategory_ActivityCategoryId",
                table: "gms.Activity",
                column: "ActivityCategoryId",
                principalTable: "gms.ActivityCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Activity_gms.GymBranch_BranchId",
                table: "gms.Activity",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ActivityCategory_gms.GymBranch_BranchId",
                table: "gms.ActivityCategory",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MembershipActivity_gms.Activity_ActivityId",
                table: "gms.MembershipActivity",
                column: "ActivityId",
                principalTable: "gms.Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MembershipActivity_gms.GymMembershipPlan_ActivityId",
                table: "gms.MembershipActivity",
                column: "ActivityId",
                principalTable: "gms.GymMembershipPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.WorkoutPlan_gms.GymBranch_BranchId",
                table: "gms.WorkoutPlan",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.WorkoutPlan_gms.Identity.GymIdentityUser_AssignedByGymStaffUserId",
                table: "gms.WorkoutPlan",
                column: "AssignedByGymStaffUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.WorkoutPlan_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.WorkoutPlan",
                column: "GymMemberUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.Activity_ActivityId",
                table: "gms.WorkoutPlanActivity",
                column: "ActivityId",
                principalTable: "gms.Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.WorkoutPlan_WorkoutPlanId",
                table: "gms.WorkoutPlanActivity",
                column: "WorkoutPlanId",
                principalTable: "gms.WorkoutPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.Activity_gms.ActivityCategory_ActivityCategoryId",
                table: "gms.Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.Activity_gms.GymBranch_BranchId",
                table: "gms.Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.ActivityCategory_gms.GymBranch_BranchId",
                table: "gms.ActivityCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MembershipActivity_gms.Activity_ActivityId",
                table: "gms.MembershipActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MembershipActivity_gms.GymMembershipPlan_ActivityId",
                table: "gms.MembershipActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.WorkoutPlan_gms.GymBranch_BranchId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.WorkoutPlan_gms.Identity.GymIdentityUser_AssignedByGymStaffUserId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.WorkoutPlan_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.Activity_ActivityId",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.WorkoutPlan_WorkoutPlanId",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.DropIndex(
                name: "IX_gms.WorkoutPlan_AssignedByGymStaffUserId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.WorkoutPlan_BranchId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.WorkoutPlan_GymMemberUserId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.ActivityCategory_BranchId",
                table: "gms.ActivityCategory");

            migrationBuilder.DropIndex(
                name: "IX_gms.Activity_BranchId",
                table: "gms.Activity");

            migrationBuilder.DropColumn(
                name: "AssignedByGymStaffUserId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "GymMemberUserId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "WorkoutPlanStatusId",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "MembershipPlanId",
                table: "gms.MembershipActivity");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.ActivityCategory");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.Activity");

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 971, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 971, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 984, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 990, DateTimeKind.Utc).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 990, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 990, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 992, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 992, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 993, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 21, 15, 49, 54, 995, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.AddForeignKey(
                name: "FK_gms.Activity_gms.ActivityCategory_ActivityCategoryId",
                table: "gms.Activity",
                column: "ActivityCategoryId",
                principalTable: "gms.ActivityCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MembershipActivity_gms.Activity_ActivityId",
                table: "gms.MembershipActivity",
                column: "ActivityId",
                principalTable: "gms.Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.Activity_ActivityId",
                table: "gms.WorkoutPlanActivity",
                column: "ActivityId",
                principalTable: "gms.Activity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.WorkoutPlanActivity_gms.WorkoutPlan_WorkoutPlanId",
                table: "gms.WorkoutPlanActivity",
                column: "WorkoutPlanId",
                principalTable: "gms.WorkoutPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
