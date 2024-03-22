using gms.data.Models.Activity;
using gms.data.Models.Enum;
using gms.data.Models.Gym;
using gms.data.Models.Shared;
using gms.data.Models.Subscription;
using gms.data.Models.Workout;
using Microsoft.EntityFrameworkCore;

namespace gms.data;
public class ApplicationDbContext : DbContext //IdentityDbContext<GymUserEntity>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    //public DbSet<IdentityRoleClaim<string>> RoleClaims { get; set; }
    //public DbSet<IdentityRole> Roles { get; set; }
    //public DbSet<IdentityUserClaim<string>> UserClaims { get; set; }
    //public DbSet<GymUserEntity> Users { get; set; }
    //public DbSet<IdentityUserLogin<string>> UserLogins { get; set; }
    //public DbSet<IdentityUserRole<string>> UserRoles { get; set; }
    //public DbSet<IdentityUserToken<string>> UserTokens { get; set; }


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
    public DbSet<SubscriptionStatusEnumEntity> SubscriptionStatuses { get; set; }
    public DbSet<GenderEnumEntity> Gender { get; set; }
    public DbSet<MemberLevelEnumEntity> MemberLevels { get; set; }
    #endregion
    
    #region Workout
    public DbSet<WorkoutPlanEntity> WorkoutPlans { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
