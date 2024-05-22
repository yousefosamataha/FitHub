using gms.data.Models.Identity;
using gms.service.Identity.GymUserRepository;
using Microsoft.AspNetCore.Identity;
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
    private UserManager<GymUserEntity> _userManager;
    private IGymUserService _gymUserService;
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
    protected UserManager<GymUserEntity> userManager =>
        _userManager ?? HttpContext.RequestServices.GetRequiredService<UserManager<GymUserEntity>>();

    protected IGymUserService gymUserService =>
        _gymUserService ?? HttpContext.RequestServices.GetRequiredService<IGymUserService>();
    #endregion

    public int GetUserId()
    {
		if (int.TryParse(httpContextAccessor.HttpContext.User.FindFirst("UserId")?.Value, out int result))
            return result;
        else
            return 0;
    }

    public int GetBranchId()
    {
        if (int.TryParse(httpContextAccessor.HttpContext.User.FindFirst("BranchId")?.Value, out int result))
            return result;
        else
            return 0;
    }

    public int GetGymId()
    {
        if (int.TryParse(httpContextAccessor.HttpContext.User.FindFirst("GymId")?.Value, out int result))
            return result;
        else
            return 0;
    }

    public async Task<GymUserEntity> GetCurrentUserData()
    {
        System.Security.Claims.ClaimsPrincipal currentUser = this.User;
        var currentUserData = await userManager.GetUserAsync(currentUser);
        var allUserData = await gymUserService.GetGymUserByEmail(currentUserData.Email);
        return allUserData;
    }

    public Dictionary<string, object> GetScopesInformation()
    {
        Dictionary<string, object> scopeInfo = new();
        scopeInfo.Add("MachineName", Environment.MachineName);
        scopeInfo.Add("Environment", "Development");
        scopeInfo.Add("AppName", "Logging Scopes");

        return scopeInfo;
    }
}
