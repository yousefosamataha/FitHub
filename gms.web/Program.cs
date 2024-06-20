using gms.service.Background;
using gms.web.Extensions.Database;
using gms.web.Extensions.HangFire;
using gms.web.Extensions.Identity;
using gms.web.Extensions.Localization;
using gms.web.Extensions.Services;
using gms.web.Filters;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Serilog;
using Serilog.Extensions.Hosting;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
{
    builder.Logging.ClearProviders();

    Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();



    builder.Host.UseSerilog(Log.Logger);

	//Add HttpContextAccessor
	builder.Services.AddHttpContextAccessor();

    // Add Hangfire
    builder.Services.AddHangFireConfiguration(builder.Configuration);

    // Add Database
    builder.Services.AddDatabaseConfiguration(builder.Configuration);

    // Add Service To Run and Apply Migration Automtic
    builder.Services.AddHostedService<MigrationHostedService>();

    // Add Services
    builder.Services.AddCustomServices();

    // Add Localization
    builder.Services.AddLocalizationConfiguration();

    // Add Identity
    builder.Services.AddIdentityConfiguration();

    // Add Permission Policy
    builder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
    builder.Services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    // Add Sessions
    builder.Services.AddDistributedMemoryCache();
    builder.Services.AddSession(options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout.
        options.Cookie.HttpOnly = true; // Make the session cookie HTTP only.
        options.Cookie.IsEssential = true; // Mark the session cookie as essential.
    });

    builder.Services.AddControllersWithViews();

	builder.Services.AddSingleton<DiagnosticContext>();

	builder.Services.AddSignalR();
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



	app.UseHangfireDashboard("/hangfire");

    app.MapRazorPages();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    //RecurringJob.AddOrUpdate<MembershipExpirationJob>(
    //job => job.CheckExpiringMembershipsAsync(),
    //Cron.Daily);

    app.Run();
}


