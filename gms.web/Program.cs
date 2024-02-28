using gms.data;
using gms.data.Models;
using gms.data.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.Globalization;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
                                                        options.UseSqlServer(connectionString));

    builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    builder.Services.AddIdentity<GymUserEntity, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultUI();

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
        var supportedLanguages = new[]
        {
            new CultureInfo(CulturesInfoStrings.English),
            new CultureInfo(CulturesInfoStrings.Arabic),
            new CultureInfo(CulturesInfoStrings.English),
            new CultureInfo(CulturesInfoStrings.French)
        };

        options.DefaultRequestCulture = new RequestCulture(culture: supportedLanguages[0], uiCulture: supportedLanguages[0]);
        options.SupportedCultures = supportedLanguages;
        options.SupportedUICultures = supportedLanguages;

    });

    builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
}

WebApplication? app = builder.Build();
{
    // Configure the HTTP request pipeline.
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

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    app.MapRazorPages();

    using var scope = app.Services.CreateScope();
    IServiceProvider services = scope.ServiceProvider;
    ILoggerProvider LoggerProvider = services.GetRequiredService<ILoggerProvider>();
    ILogger logger = LoggerProvider.CreateLogger("app");
    try
    {
        UserManager<GymUserEntity> userManager = services.GetRequiredService<UserManager<GymUserEntity>>();
        RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        await Seeds.SeedBasicUserAsync(userManager);
        await Seeds.SeedSuperAdminUserAsync(userManager, roleManager);
        logger.LogInformation("Data Seeded");
        logger.LogInformation("Application Started");
    }
    catch (Exception ex)
    {
        logger.LogWarning(ex, "An error Occured While Seeding Data");
    }

    app.Run();
}


