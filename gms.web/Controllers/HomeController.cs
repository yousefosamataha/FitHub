using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace gms.web.Controllers;

public class HomeController : BaseController<HomeController>
{
    private RequestLocalizationOptions _requestLocalizationOptions;
    public HomeController(IOptions<RequestLocalizationOptions> options)
    {
        _requestLocalizationOptions = options.Value;
    }

    public IActionResult Index()
    {
        ViewBag.WelcomeMessage = localizer["welcome"];
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SetLanguage(string culture, string redirecturl)
    {
        Response.Cookies.Append
        (
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(7) }
        );
        return LocalRedirect(redirecturl);
    }
}