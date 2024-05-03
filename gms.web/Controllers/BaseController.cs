using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace gms.web.Controllers;
public class BaseController<T> : Controller where T : BaseController<T>
{
    #region Private
    private ILogger<T>? _logger;
    private IStringLocalizer<T>? _localizer;
    private RequestLocalizationOptions _requestLocalizationOptions;
    private IHttpContextAccessor _httpContextAccessor;
    #endregion

    #region Protected
    protected ILogger<T>? logger =>
        _logger ?? HttpContext.RequestServices.GetRequiredService<ILogger<T>>();

    protected IStringLocalizer<T>? localizer =>
        _localizer ?? HttpContext.RequestServices.GetRequiredService<IStringLocalizer<T>>();

    protected RequestLocalizationOptions? requestLocalizationOptions =>
        _requestLocalizationOptions ?? HttpContext.RequestServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;

    protected IHttpContextAccessor httpContextAccessor =>
        _httpContextAccessor ?? HttpContext.RequestServices.GetRequiredService<IHttpContextAccessor>();
    #endregion

    public string GetUserId()
    {
        return httpContextAccessor.HttpContext.User.FindFirst("UserId")?.Value;
    }
}
