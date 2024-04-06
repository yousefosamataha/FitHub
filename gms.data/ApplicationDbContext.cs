using gms.data.Models.Activity;
using gms.data.Models.Class;
using gms.data.Models.Enum;
using gms.data.Models.Event;
using gms.data.Models.Gym;
using gms.data.Models.Nutrition;
using gms.data.Models.Shared;
using gms.data.Models.Staff;
using gms.data.Models.Subscription;
using gms.data.Models.Workout;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace gms.data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    #region Subscription
    public DbSet<PlanEntity> SystemPlans { get; set; }
    public DbSet<SystemSubscriptionEntity> SystemSubscriptions { get; set; }
    public DbSet<SubscriptionPaymentEntity> SubscriptionsPayments { get; set; }
    #endregion

    #region Gym
    public DbSet<GymEntity> Gyms { get; set; }
    public DbSet<GymBranchEntity> GymBranches { get; set; }
    public DbSet<GymGeneralSettingEntity> GymGeneralSettings { get; set; }
    public DbSet<GymNotificationEntity> GymNotifications { get; set; }
    public DbSet<MeasurementImageEntity> MeasurementImages { get; set; }
    public DbSet<GymMeasurementEntity> GymMeasurements { get; set; }
    //public DbSet<GymStaffSpecializationEntity> GymStaffSpecializations { get; set; }
    //public DbSet<GymBranchUsersEntity> GymBranchUsers { get; set; }
    #endregion

    #region Shared
    public DbSet<CountryEntity> Countries { get; set; }
    #endregion

    #region Activity
    public DbSet<ActivityCategoryEntity> ActivityCategories { get; set; }
    public DbSet<ActivityVideoEntity> ActivityVideos { get; set; }
    public DbSet<ActivityEntity> Activities { get; set; }
    #endregion

    #region Enum
    public DbSet<PaymentMethodEnumEntity> PaymentMethods { get; set; }
    public DbSet<SubscriptionTypeEnumEntity> SubscriptionTypes { get; set; }
    public DbSet<StatusEnumEntity> Statuses { get; set; }
    public DbSet<GenderEnumEntity> Gender { get; set; }
    public DbSet<MemberLevelEnumEntity> MemberLevels { get; set; }
    public DbSet<GymResultMeasurementEnumEntity> GymResultMeasurements { get; set; }

    #endregion

    #region Workout
    public DbSet<WorkoutPlanEntity> WorkoutPlans { get; set; }
    public DbSet<WorkoutPlanActivityEntity> WorkoutPlanActivities { get; set; }
    #endregion

    #region Nutrition
    public DbSet<NutritionPlanEntity> NutritionPlans { get; set; }
    public DbSet<NutritionPlanMealEntity> NutritionPlanMeals { get; set; }
    public DbSet<MealTimeEntity> MealTimes { get; set; }
    public DbSet<MealIngredientEntity> MealIngredients { get; set; }
    #endregion

    #region Class
    public DbSet<ClassScheduleEntity> ClassSchedules { get; set; }
    public DbSet<ClassLocationEntity> ClassLocations { get; set; }
    public DbSet<ClassScheduleDayEntity> ClassScheduleDays { get; set; }
    #endregion

    #region Staff
    public DbSet<StaffClassEntity> StaffClasses { get; set; }
    #endregion

    #region Event
    public DbSet<GymEventPlaceEntity> GymEventPlaces { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(assembly: Assembly.GetExecutingAssembly(),
        predicate: t => t.Namespace != null && t.Namespace.Equals(nameof(gms.data.IdentityConfiguration)));
    }
}
