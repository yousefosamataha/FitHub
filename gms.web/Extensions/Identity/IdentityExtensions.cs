using gms.data.Models.Identity;
using gms.data;
using Microsoft.AspNetCore.Identity;

namespace gms.web.Extensions.Identity;

public static class IdentityExtensions
{
    public static void AddIdentityConfiguration(this IServiceCollection services)
    {
        services.AddIdentity<GymUserEntity, GymIdentityRoleEntity>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI();

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/Identity/Account/Login";
            options.LogoutPath = "/Identity/Account/Logout";
            options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            options.SlidingExpiration = true;
        });

        services.Configure<SecurityStampValidatorOptions>(options =>
        {
            options.ValidationInterval = TimeSpan.Zero;
        });
    }
}
