using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace gms.web.Extensions.Localization;

public static class LocalizationExtensions
{
    public static void AddLocalizationConfiguration(this IServiceCollection services)
    {
        services.AddLocalization();
        services.AddSingleton<IStringLocalizerFactory, JsonStringLocalizerFactory>();

        services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(JsonStringLocalizerFactory));
                });

        services.Configure<RequestLocalizationOptions>(options =>
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
    }
}
