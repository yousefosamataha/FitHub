using gms.web.Extensions.Database;
using gms.web.Extensions.Identity;
using gms.web.Extensions.Localization;
using gms.web.Extensions.MiddlewareExtensions;
using gms.web.Extensions.Services;
using gms.web.Filters;
using Microsoft.AspNetCore.Authorization;
using Serilog;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
{
    Serilog.ILogger logger = new LoggerConfiguration()
								.ReadFrom.Configuration(builder.Configuration)
								.Enrich.FromLogContext()
								.WriteTo.Console()
								.WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
								.CreateLogger();


    builder.Host.UseSerilog();

    builder.Logging.ClearProviders();
    builder.Logging.AddSerilog(logger);

	// Add services
	builder.Services.AddDatabaseConfiguration(builder.Configuration);
	
	builder.Services.AddCustomServices();
	
	builder.Services.AddLocalizationConfiguration();

	builder.Services.AddIdentityConfiguration();

	builder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
	builder.Services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();

	builder.Services.AddDatabaseDeveloperPageExceptionFilter();

	builder.Services.AddDistributedMemoryCache();
	builder.Services.AddSession(options =>
	{
		options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout.
		options.Cookie.HttpOnly = true; // Make the session cookie HTTP only.
		options.Cookie.IsEssential = true; // Mark the session cookie as essential.
	});

	builder.Services.AddControllersWithViews();

	builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
}


WebApplication? app = builder.Build();
{
	app.ConfigureCustomMiddleware(app.Environment);

    app.UseSession();

    app.MapRazorPages();

	app.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}"
	);

	app.Run();
}


