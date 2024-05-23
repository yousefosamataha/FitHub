using gms.service.Activity.ActivityCategoryRepository;
using gms.service.Activity.ActivityRepository;
using gms.service.Activity.ActivityVideoRepository;
using gms.service.Activity.MembershipActivityRepository;
using gms.service.Class.ClassScheduleDayRepository;
using gms.service.Class.ClassScheduleRepository;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymGeneralSettingsRepository;
using gms.service.Gym.GymGroupRepository;
using gms.service.Gym.GymLocationRepository;
using gms.service.Gym.GymMemberGroupRepository;
using gms.service.Gym.GymRepository;
using gms.service.Identity.GymRolesRepository;
using gms.service.Identity.GymUserRepository;
using gms.service.Membership.GymMemberMembershipRepository;
using gms.service.Membership.GymMembershipPlanRepository;
using gms.service.Shared.CountryRepository;
using gms.service.Subscription.SystemSubscriptionRepository;
using gms.services.Base;

namespace gms.web.Extensions.Services;

public static class ServiceExtensions
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IGymService, GymService>();
        services.AddScoped<IGymBranchService, GymBranchService>();
        services.AddScoped<ISystemSubscriptionService, SystemSubscriptionService>();
        services.AddScoped<ICountryService, CountryService>();
        services.AddScoped<IGymGeneralSettingService, GymGeneralSettingService>();
        services.AddScoped<IGymMembershipPlanService, GymMembershipPlanService>();
        services.AddScoped<IGymGroupService, GymGroupService>();
        services.AddScoped<IGymUserService, GymUserService>();
        services.AddScoped<IActivityService, ActivityService>();
        services.AddScoped<IActivityCategoryService, ActivityCategoryService>();
        services.AddScoped<IMembershipActivityService, MembershipActivityService>();
        services.AddScoped<IActivityVideoService, ActivityVideoService>();
        services.AddScoped<IGymRolesService, GymRolesService>();
        services.AddScoped<IClassScheduleService, ClassScheduleService>();
        services.AddScoped<IGymLocationService, GymLocationService>();
        services.AddScoped<IClassScheduleDayService, ClassScheduleDayService>();
        services.AddScoped<IGymMemberGroupService, GymMemberGroupService>();
        services.AddScoped<IGymMemberMembershipService, GymMemberMembershipService>();
    }
}
