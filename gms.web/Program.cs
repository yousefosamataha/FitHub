using Autofac.Core;
using gms.data;
using gms.data.Models.Identity;
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
using gms.web.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Serilog;
using System.Globalization;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
{
	string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

	Log.Logger = new LoggerConfiguration()
					.ReadFrom.Configuration(builder.Configuration)
					.Enrich.FromLogContext()
					.WriteTo.Console()
					.WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
					.CreateLogger();

	builder.Host.UseSerilog();

    builder.Services.AddDbContextPool<ApplicationDbContext>(options => 
	{
		options.UseSqlServer(connectionString);
        options.UseLazyLoadingProxies();
    });

	builder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();

	builder.Services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();

	builder.Services.AddDatabaseDeveloperPageExceptionFilter();

	builder.Services.AddIdentity<GymUserEntity, GymIdentityRoleEntity>(options => options.SignIn.RequireConfirmedAccount = true)
					.AddEntityFrameworkStores<ApplicationDbContext>()
					.AddDefaultUI();


	builder.Services.ConfigureApplicationCookie(options =>
	{
		options.LoginPath = "/Identity/Account/Login";
		options.LogoutPath = "/Identity/Account/Logout";
		options.AccessDeniedPath = "/Identity/Account/AccessDenied";
		options.SlidingExpiration = true;
	});

	builder.Services.Configure<SecurityStampValidatorOptions>(options =>
	{
		options.ValidationInterval = TimeSpan.Zero;
	});

    builder.Services.AddDistributedMemoryCache(); // This is required to store session data in memory.
    
	builder.Services.AddSession(options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout.
        options.Cookie.HttpOnly = true; // Make the session cookie HTTP only.
        options.Cookie.IsEssential = true; // Mark the session cookie as essential.
    });
    
	builder.Services.AddControllersWithViews();

	builder.Services.AddLocalization();

	builder.Services.AddSingleton<IStringLocalizerFactory, JsonStringLocalizerFactory>();

	builder.Services.AddMvc()
					.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
					.AddDataAnnotationsLocalization(options =>
					{
						options.DataAnnotationLocalizerProvider = (type, factory) =>
							factory.Create(typeof(JsonStringLocalizerFactory));
					});

	builder.Services.Configure<RequestLocalizationOptions>(options =>
	{
		CultureInfo[]? supportedLanguages = new[]
		{
			new CultureInfo(CulturesInfoStrings.English),
			new CultureInfo(CulturesInfoStrings.Arabic),
			new CultureInfo(CulturesInfoStrings.French)
		};

		options.DefaultRequestCulture = new RequestCulture(culture: supportedLanguages[0], uiCulture: supportedLanguages[0]);
		options.SupportedCultures = supportedLanguages;
		options.SupportedUICultures = supportedLanguages;

	});

	builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

	builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

	builder.Services.AddScoped(typeof(IGymService), typeof(GymService));

	builder.Services.AddScoped(typeof(IGymBranchService), typeof(GymBranchService));

	builder.Services.AddScoped(typeof(ISystemSubscriptionService), typeof(SystemSubscriptionService));

	builder.Services.AddScoped(typeof(ICountryService), typeof(CountryService));

	builder.Services.AddScoped(typeof(IGymGeneralSettingService), typeof(GymGeneralSettingService));

	builder.Services.AddScoped(typeof(IGymMembershipPlanService), typeof(GymMembershipPlanService));

	builder.Services.AddScoped(typeof(IGymGroupService), typeof(GymGroupService));

	builder.Services.AddScoped(typeof(IGymUserService), typeof(GymUserService));

	builder.Services.AddScoped(typeof(IActivityService), typeof(ActivityService));

	builder.Services.AddScoped(typeof(IActivityCategoryService), typeof(ActivityCategoryService));

	builder.Services.AddScoped(typeof(IMembershipActivityService), typeof(MembershipActivityService));

	builder.Services.AddScoped(typeof(IActivityVideoService), typeof(ActivityVideoService));

	builder.Services.AddScoped(typeof(IGymRolesService), typeof(GymRolesService));

	builder.Services.AddScoped(typeof(IClassScheduleService), typeof(ClassScheduleService));

	builder.Services.AddScoped(typeof(IGymLocationService), typeof(GymLocationService));

	builder.Services.AddScoped(typeof(IClassScheduleDayService), typeof(ClassScheduleDayService));

	builder.Services.AddScoped(typeof(IGymMemberGroupService), typeof(GymMemberGroupService));

	builder.Services.AddScoped(typeof(IGymMemberMembershipService), typeof(GymMemberMembershipService));
}


WebApplication? app = builder.Build();
{
    app.UseSerilogRequestLogging();

    if (app.Environment.IsDevelopment())
	{
		app.UseMigrationsEndPoint();
	}
	else
	{
		app.UseExceptionHandler("/Home/Error");
		// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
		app.UseHsts();
	}

	app.UseHttpsRedirection();

	app.UseStaticFiles();

	app.UseRouting();

	string[] supportedCultures = new[] { CulturesInfoStrings.English, CulturesInfoStrings.Arabic, CulturesInfoStrings.French };

	app.UseRequestLocalization(new RequestLocalizationOptions()
		.SetDefaultCulture(supportedCultures[0])
		.AddSupportedCultures(supportedCultures)
		.AddSupportedUICultures(supportedCultures));

	app.UseAuthentication();
	app.UseAuthorization();

    app.UseSession();

    app.MapRazorPages();

	app.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}"
	);

	//using var scope = app.Services.CreateScope();
	//IServiceProvider services = scope.ServiceProvider;
	//ILoggerProvider LoggerProvider = services.GetRequiredService<ILoggerProvider>();
	//ILogger logger = LoggerProvider.CreateLogger("app");
	//try
	//{
	//	UserManager<GymUserEntity> userManager = services.GetRequiredService<UserManager<GymUserEntity>>();

	//	RoleManager<GymIdentityRoleEntity> roleManager = services.GetRequiredService<RoleManager<GymIdentityRoleEntity>>();

	//	await Seeds.SeedBasicUserAsync(userManager);

	//	await Seeds.SeedSuperAdminUserAsync(userManager, roleManager);

	//	logger.LogInformation("Data Seeded");

	//	logger.LogInformation("Application Started");
	//}
	//catch (Exception ex)
	//{
	//	logger.LogWarning(ex, "An error Occured While Seeding Data");
	//}

	app.Run();
}


