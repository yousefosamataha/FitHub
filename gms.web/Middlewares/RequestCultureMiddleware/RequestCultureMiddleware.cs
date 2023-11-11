using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace gms.web.Middlewares.RequestCultureMiddleware;

public class RequestCultureMiddleware
{
    private readonly RequestDelegate _next;

    public RequestCultureMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        string? currentCulture = context.Request.Cookies[CookieRequestCultureProvider.DefaultCookieName];
        string? browserLanguage = context.Request.Headers["Accept-Language"].ToString()[..2];
        if (string.IsNullOrWhiteSpace(currentCulture))
        {
            string culture = string.Empty;

            switch (browserLanguage)
            {

                case "ar":
                    culture = "ar-EG";
                    break;
                case "fr":
                    culture = "fr-FR";
                    break;
                default:
                    culture = "en-US";
                    break;
            }
            context.Features.Set<IRequestCultureFeature>
            (
                new RequestCultureFeature
                (
                    new RequestCulture(culture, culture), null
                )
            );
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);

        }

        await _next(context).ConfigureAwait(false);
    }
}
