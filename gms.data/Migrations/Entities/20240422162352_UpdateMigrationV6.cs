using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateMigrationV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassSchedule_gms.ClassLocation_ClassLocationId",
                table: "gms.ClassSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymEventReservation_gms.GymEventPlace_GymEventPlaceId",
                table: "gms.GymEventReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MealIngredient_gms.NutritionPlanMeal_MealId",
                table: "gms.MealIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MeasurementImage_gms.GymMeasurement_MeasurementId",
                table: "gms.MeasurementImage");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.MealTime_MealTimeId",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.NutritionPlan_NutritionPlanId",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropTable(
                name: "gms.ClassLocation");

            migrationBuilder.DropTable(
                name: "gms.GymEventPlace");

            migrationBuilder.RenameColumn(
                name: "MeasurementId",
                table: "gms.MeasurementImage",
                newName: "GymMeasurementId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.MeasurementImage_MeasurementId",
                table: "gms.MeasurementImage",
                newName: "IX_gms.MeasurementImage_GymMeasurementId");

            migrationBuilder.RenameColumn(
                name: "MealId",
                table: "gms.MealIngredient",
                newName: "NutritionPlanMealId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.MealIngredient_MealId",
                table: "gms.MealIngredient",
                newName: "IX_gms.MealIngredient_NutritionPlanMealId");

            migrationBuilder.RenameColumn(
                name: "GymEventPlaceId",
                table: "gms.GymEventReservation",
                newName: "GymLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.GymEventReservation_GymEventPlaceId",
                table: "gms.GymEventReservation",
                newName: "IX_gms.GymEventReservation_GymLocationId");

            migrationBuilder.RenameColumn(
                name: "ClassLocationId",
                table: "gms.ClassSchedule",
                newName: "GymLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.ClassSchedule_ClassLocationId",
                table: "gms.ClassSchedule",
                newName: "IX_gms.ClassSchedule_GymLocationId");

            migrationBuilder.AddColumn<int>(
                name: "AssignedByGymStaffUserId",
                table: "gms.NutritionPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.NutritionPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymMemberUserId",
                table: "gms.NutritionPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "NutritionPlanStatusId",
                table: "gms.NutritionPlan",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.MealTime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "gms.MealIngredient",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.GymNotification",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymReceiverUserId",
                table: "gms.GymNotification",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymSenderUserId",
                table: "gms.GymNotification",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GymMemberUserId",
                table: "gms.GymMeasurement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResultDate",
                table: "gms.GymMeasurement",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "gms.GymEventReservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "gms.GymLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.GymLocation_gms.GymBranch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "gms.GymBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 112, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 112, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 128, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 128, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 128, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 128, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 128, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 128, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 128, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 142, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 142, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 142, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 144, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 144, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 145, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 146, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 146, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 147, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 147, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 147, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 16, 23, 48, 147, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.CreateIndex(
                name: "IX_gms.NutritionPlan_AssignedByGymStaffUserId",
                table: "gms.NutritionPlan",
                column: "AssignedByGymStaffUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.NutritionPlan_BranchId",
                table: "gms.NutritionPlan",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.NutritionPlan_GymMemberUserId",
                table: "gms.NutritionPlan",
                column: "GymMemberUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.MealTime_BranchId",
                table: "gms.MealTime",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymNotification_BranchId",
                table: "gms.GymNotification",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymNotification_GymReceiverUserId",
                table: "gms.GymNotification",
                column: "GymReceiverUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymNotification_GymSenderUserId",
                table: "gms.GymNotification",
                column: "GymSenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymMeasurement_GymMemberUserId",
                table: "gms.GymMeasurement",
                column: "GymMemberUserId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymEventReservation_BranchId",
                table: "gms.GymEventReservation",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_gms.GymLocation_BranchId",
                table: "gms.GymLocation",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassSchedule_gms.GymLocation_GymLocationId",
                table: "gms.ClassSchedule",
                column: "GymLocationId",
                principalTable: "gms.GymLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymEventReservation_gms.GymBranch_BranchId",
                table: "gms.GymEventReservation",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymEventReservation_gms.GymLocation_GymLocationId",
                table: "gms.GymEventReservation",
                column: "GymLocationId",
                principalTable: "gms.GymLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymMeasurement_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.GymMeasurement",
                column: "GymMemberUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymNotification_gms.GymBranch_BranchId",
                table: "gms.GymNotification",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymNotification_gms.Identity.GymIdentityUser_GymReceiverUserId",
                table: "gms.GymNotification",
                column: "GymReceiverUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymNotification_gms.Identity.GymIdentityUser_GymSenderUserId",
                table: "gms.GymNotification",
                column: "GymSenderUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MealIngredient_gms.NutritionPlanMeal_NutritionPlanMealId",
                table: "gms.MealIngredient",
                column: "NutritionPlanMealId",
                principalTable: "gms.NutritionPlanMeal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MealTime_gms.GymBranch_BranchId",
                table: "gms.MealTime",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MeasurementImage_gms.GymMeasurement_GymMeasurementId",
                table: "gms.MeasurementImage",
                column: "GymMeasurementId",
                principalTable: "gms.GymMeasurement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.NutritionPlan_gms.GymBranch_BranchId",
                table: "gms.NutritionPlan",
                column: "BranchId",
                principalTable: "gms.GymBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.NutritionPlan_gms.Identity.GymIdentityUser_AssignedByGymStaffUserId",
                table: "gms.NutritionPlan",
                column: "AssignedByGymStaffUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.NutritionPlan_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.NutritionPlan",
                column: "GymMemberUserId",
                principalTable: "gms.Identity.GymIdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.MealTime_MealTimeId",
                table: "gms.NutritionPlanMeal",
                column: "MealTimeId",
                principalTable: "gms.MealTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.NutritionPlan_NutritionPlanId",
                table: "gms.NutritionPlanMeal",
                column: "NutritionPlanId",
                principalTable: "gms.NutritionPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.ClassSchedule_gms.GymLocation_GymLocationId",
                table: "gms.ClassSchedule");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymEventReservation_gms.GymBranch_BranchId",
                table: "gms.GymEventReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymEventReservation_gms.GymLocation_GymLocationId",
                table: "gms.GymEventReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymMeasurement_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.GymMeasurement");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymNotification_gms.GymBranch_BranchId",
                table: "gms.GymNotification");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymNotification_gms.Identity.GymIdentityUser_GymReceiverUserId",
                table: "gms.GymNotification");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.GymNotification_gms.Identity.GymIdentityUser_GymSenderUserId",
                table: "gms.GymNotification");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MealIngredient_gms.NutritionPlanMeal_NutritionPlanMealId",
                table: "gms.MealIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MealTime_gms.GymBranch_BranchId",
                table: "gms.MealTime");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.MeasurementImage_gms.GymMeasurement_GymMeasurementId",
                table: "gms.MeasurementImage");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.NutritionPlan_gms.GymBranch_BranchId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.NutritionPlan_gms.Identity.GymIdentityUser_AssignedByGymStaffUserId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.NutritionPlan_gms.Identity.GymIdentityUser_GymMemberUserId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.MealTime_MealTimeId",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.NutritionPlan_NutritionPlanId",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropTable(
                name: "gms.GymLocation");

            migrationBuilder.DropIndex(
                name: "IX_gms.NutritionPlan_AssignedByGymStaffUserId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.NutritionPlan_BranchId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.NutritionPlan_GymMemberUserId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropIndex(
                name: "IX_gms.MealTime_BranchId",
                table: "gms.MealTime");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymNotification_BranchId",
                table: "gms.GymNotification");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymNotification_GymReceiverUserId",
                table: "gms.GymNotification");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymNotification_GymSenderUserId",
                table: "gms.GymNotification");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymMeasurement_GymMemberUserId",
                table: "gms.GymMeasurement");

            migrationBuilder.DropIndex(
                name: "IX_gms.GymEventReservation_BranchId",
                table: "gms.GymEventReservation");

            migrationBuilder.DropColumn(
                name: "AssignedByGymStaffUserId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "GymMemberUserId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "NutritionPlanStatusId",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.MealTime");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.GymNotification");

            migrationBuilder.DropColumn(
                name: "GymReceiverUserId",
                table: "gms.GymNotification");

            migrationBuilder.DropColumn(
                name: "GymSenderUserId",
                table: "gms.GymNotification");

            migrationBuilder.DropColumn(
                name: "GymMemberUserId",
                table: "gms.GymMeasurement");

            migrationBuilder.DropColumn(
                name: "ResultDate",
                table: "gms.GymMeasurement");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "gms.GymEventReservation");

            migrationBuilder.RenameColumn(
                name: "GymMeasurementId",
                table: "gms.MeasurementImage",
                newName: "MeasurementId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.MeasurementImage_GymMeasurementId",
                table: "gms.MeasurementImage",
                newName: "IX_gms.MeasurementImage_MeasurementId");

            migrationBuilder.RenameColumn(
                name: "NutritionPlanMealId",
                table: "gms.MealIngredient",
                newName: "MealId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.MealIngredient_NutritionPlanMealId",
                table: "gms.MealIngredient",
                newName: "IX_gms.MealIngredient_MealId");

            migrationBuilder.RenameColumn(
                name: "GymLocationId",
                table: "gms.GymEventReservation",
                newName: "GymEventPlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.GymEventReservation_GymLocationId",
                table: "gms.GymEventReservation",
                newName: "IX_gms.GymEventReservation_GymEventPlaceId");

            migrationBuilder.RenameColumn(
                name: "GymLocationId",
                table: "gms.ClassSchedule",
                newName: "ClassLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_gms.ClassSchedule_GymLocationId",
                table: "gms.ClassSchedule",
                newName: "IX_gms.ClassSchedule_ClassLocationId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "gms.MealIngredient",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.CreateTable(
                name: "gms.ClassLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.ClassLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gms.ClassLocation_gms.GymBranch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "gms.GymBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gms.GymEventPlace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlaceName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gms.GymEventPlace", x => x.Id);
                });

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
                name: "IX_gms.ClassLocation_BranchId",
                table: "gms.ClassLocation",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.ClassSchedule_gms.ClassLocation_ClassLocationId",
                table: "gms.ClassSchedule",
                column: "ClassLocationId",
                principalTable: "gms.ClassLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.GymEventReservation_gms.GymEventPlace_GymEventPlaceId",
                table: "gms.GymEventReservation",
                column: "GymEventPlaceId",
                principalTable: "gms.GymEventPlace",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MealIngredient_gms.NutritionPlanMeal_MealId",
                table: "gms.MealIngredient",
                column: "MealId",
                principalTable: "gms.NutritionPlanMeal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.MeasurementImage_gms.GymMeasurement_MeasurementId",
                table: "gms.MeasurementImage",
                column: "MeasurementId",
                principalTable: "gms.GymMeasurement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.MealTime_MealTimeId",
                table: "gms.NutritionPlanMeal",
                column: "MealTimeId",
                principalTable: "gms.MealTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.NutritionPlanMeal_gms.NutritionPlan_NutritionPlanId",
                table: "gms.NutritionPlanMeal",
                column: "NutritionPlanId",
                principalTable: "gms.NutritionPlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
