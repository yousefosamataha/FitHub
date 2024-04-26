using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gms.data.Migrations.Entities
{
    /// <inheritdoc />
    public partial class AddDeletedByAndModifiedByToBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 626, DateTimeKind.Utc).AddTicks(2690), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 626, DateTimeKind.Utc).AddTicks(2702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 649, DateTimeKind.Utc).AddTicks(2620), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 649, DateTimeKind.Utc).AddTicks(2635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 649, DateTimeKind.Utc).AddTicks(2639), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 649, DateTimeKind.Utc).AddTicks(2642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 649, DateTimeKind.Utc).AddTicks(2646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 649, DateTimeKind.Utc).AddTicks(2651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 649, DateTimeKind.Utc).AddTicks(2654), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 670, DateTimeKind.Utc).AddTicks(8626), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 670, DateTimeKind.Utc).AddTicks(8652), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 670, DateTimeKind.Utc).AddTicks(8656), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 673, DateTimeKind.Utc).AddTicks(7317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 673, DateTimeKind.Utc).AddTicks(7328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5379), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5388), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5392), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5396), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5399), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5405), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5409), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 674, DateTimeKind.Utc).AddTicks(5412), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 676, DateTimeKind.Utc).AddTicks(9345), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 676, DateTimeKind.Utc).AddTicks(9365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 677, DateTimeKind.Utc).AddTicks(3398), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 677, DateTimeKind.Utc).AddTicks(3410), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 677, DateTimeKind.Utc).AddTicks(3415), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedById", "ModifiedById" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 20, 5, 677, DateTimeKind.Utc).AddTicks(3419), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 489, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "gms.GenderEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 489, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "gms.GymResultMeasurement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 515, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 539, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 539, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "gms.MemberLevelEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 539, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 543, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "gms.PaymentMethodEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 543, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "gms.StatusEnum",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 544, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 546, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "gms.SubscriptionTypeEnum",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 546, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "gms.SystemPlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 14, 6, 13, 547, DateTimeKind.Utc).AddTicks(1228));
        }
    }
}
