using gms.web.Middlewares.ExceptionMiddleware;
using Serilog;
namespace gms.web.Extensions.MiddlewareExtensions;
public static class MiddlewareExtension
{
    public static void ConfigureCustomMiddleware(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSerilogRequestLogging();

        if (env.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
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

        app.UseExceptionHandlingMiddleware();

        app.UseSession();

        
    }
}
