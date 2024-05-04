using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class UpdateSubscriptionPaymentAndSystemSubscriptionEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.SystemSubscription_gms.SubscriptionPayment_SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropIndex(
                name: "IX_gms.SystemSubscription_SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "SubscriptionPaymentId",
                table: "gms.SystemSubscription");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.WorkoutPlanActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.WorkoutPlanActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.WorkoutPlanActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.WorkoutPlan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.WorkoutPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.WorkoutPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.SystemSubscription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.SystemSubscription",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.SystemSubscription",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.SystemPlan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.SystemPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.SystemPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.SubscriptionTypeEnum",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.SubscriptionTypeEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.SubscriptionTypeEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.SubscriptionPayment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.SubscriptionPayment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.SubscriptionPayment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.StatusEnum",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.StatusEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.StatusEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.StaffClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.StaffClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.StaffClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.PaymentMethodEnum",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.PaymentMethodEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.PaymentMethodEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.NutritionPlanMeal",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.NutritionPlanMeal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.NutritionPlanMeal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.NutritionPlan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.NutritionPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.NutritionPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.MembershipActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.MembershipActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.MembershipActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.MemberLevelEnum",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.MemberLevelEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.MemberLevelEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.MemberClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.MemberClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.MemberClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.MeasurementImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.MeasurementImage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.MeasurementImage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.MealTime",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.MealTime",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.MealTime",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.MealIngredient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.MealIngredient",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.MealIngredient",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymStaffSpecialization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymStaffSpecialization",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymStaffSpecialization",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymStaffGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymStaffGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymStaffGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymSpecialization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymSpecialization",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymSpecialization",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymResultMeasurement",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymResultMeasurement",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymResultMeasurement",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymNotification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymNotification",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymNotification",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymMembershipPlanClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymMembershipPlanClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymMembershipPlanClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymMembershipPlan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymMembershipPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymMembershipPaymentHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymMembershipPaymentHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymMembershipPaymentHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymMemberMembership",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymMemberMembership",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymMemberMembership",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymMemberGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymMemberGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymMemberGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymMeasurement",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymMeasurement",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymMeasurement",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymLocation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymGeneralSetting",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymGeneralSetting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymEventReservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymEventReservation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymEventReservation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GymBranch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GymBranch",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GymBranch",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.Gym",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.Gym",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.Gym",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.GenderEnum",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.GenderEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.GenderEnum",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.Country",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.ClassScheduleDay",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.ClassScheduleDay",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.ClassScheduleDay",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.ClassSchedule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.ClassSchedule",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.ClassSchedule",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.ActivityVideo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.ActivityVideo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.ActivityVideo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.ActivityCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.ActivityCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.ActivityCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "gms.Activity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedById",
                table: "gms.Activity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "gms.Activity",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.Country",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 39, DateTimeKind.Utc).AddTicks(8304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 39, DateTimeKind.Utc).AddTicks(8353), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7204), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7212), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7217), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7224), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 67, DateTimeKind.Utc).AddTicks(7226), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 88, DateTimeKind.Utc).AddTicks(2381), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 88, DateTimeKind.Utc).AddTicks(2448), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 88, DateTimeKind.Utc).AddTicks(2451), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 90, DateTimeKind.Utc).AddTicks(7651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 90, DateTimeKind.Utc).AddTicks(7659), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4447), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4455), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4458), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4477), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4480), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4485), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4488), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 91, DateTimeKind.Utc).AddTicks(4490), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(5250), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(5264), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8255), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8270), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8275), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 32, 37, 92, DateTimeKind.Utc).AddTicks(8310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_gms.SubscriptionPayment_SubscriptionId",
                table: "gms.SubscriptionPayment",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_gms.SubscriptionPayment_gms.SystemSubscription_SubscriptionId",
                table: "gms.SubscriptionPayment",
                column: "SubscriptionId",
                principalTable: "gms.SystemSubscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gms.SubscriptionPayment_gms.SystemSubscription_SubscriptionId",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropIndex(
                name: "IX_gms.SubscriptionPayment_SubscriptionId",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.WorkoutPlanActivity");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.WorkoutPlan");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.SystemSubscription");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.SystemPlan");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.SystemPlan");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.SystemPlan");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.SubscriptionTypeEnum");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.SubscriptionTypeEnum");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.SubscriptionTypeEnum");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.SubscriptionPayment");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.StatusEnum");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.StatusEnum");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.StatusEnum");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.StaffClass");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.StaffClass");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.StaffClass");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.PaymentMethodEnum");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.PaymentMethodEnum");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.PaymentMethodEnum");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.NutritionPlanMeal");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.NutritionPlan");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.MembershipActivity");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.MembershipActivity");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.MembershipActivity");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.MemberLevelEnum");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.MemberLevelEnum");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.MemberLevelEnum");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.MemberClass");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.MemberClass");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.MemberClass");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.MeasurementImage");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.MeasurementImage");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.MeasurementImage");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.MealTime");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.MealTime");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.MealTime");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.MealIngredient");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.MealIngredient");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.MealIngredient");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymStaffSpecialization");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymStaffGroup");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymSpecialization");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymSpecialization");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymSpecialization");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymResultMeasurement");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymResultMeasurement");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymResultMeasurement");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymNotification");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymNotification");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymNotification");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymMembershipPlanClass");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymMembershipPlan");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymMembershipPaymentHistory");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymMembershipPaymentHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymMembershipPaymentHistory");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymMemberMembership");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymMemberGroup");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymMeasurement");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymMeasurement");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymMeasurement");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymLocation");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymLocation");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymLocation");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymGroup");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymGroup");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymGeneralSetting");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymEventReservation");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymEventReservation");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymEventReservation");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GymBranch");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GymBranch");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GymBranch");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.Gym");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.Gym");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.Gym");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.GenderEnum");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.GenderEnum");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.GenderEnum");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.Country");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.Country");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.Country");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.ClassScheduleDay");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.ClassSchedule");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.ClassSchedule");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.ClassSchedule");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.ActivityVideo");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.ActivityVideo");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.ActivityVideo");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.ActivityCategory");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.ActivityCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.ActivityCategory");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "gms.Activity");

            migrationBuilder.DropColumn(
                name: "DeletedById",
                table: "gms.Activity");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "gms.Activity");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 321, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 321, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 349, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 376, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 376, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 376, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 380, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 380, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 381, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 18, 0, 0, 384, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.CreateIndex(
                name: "IX_gms.SystemSubscription_SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                column: "SubscriptionPaymentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_gms.SystemSubscription_gms.SubscriptionPayment_SubscriptionPaymentId",
                table: "gms.SystemSubscription",
                column: "SubscriptionPaymentId",
                principalTable: "gms.SubscriptionPayment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
