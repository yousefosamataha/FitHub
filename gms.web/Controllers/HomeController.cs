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
		return View();
	}
	public IActionResult AddNewMembership()
	{
		return View();
	}

    public IActionResult MembershipsList()
    {
        return View();
    }

	public IActionResult AddNewMember()
	{
		return View();
	}

	public IActionResult Memberslist()
	{
		return View();
	}

	public IActionResult AddNewStaff()
	{
		return View();
	}

	public IActionResult StaffsList()
	{
		return View();
	}

	public IActionResult Roles()
	{
		return View();
	}

	public IActionResult Permissions()
	{
		return View();
	}

	public IActionResult AddNewGroup()
	{
		return View();
	}

	public IActionResult GroupsList()
	{
		return View();
	}

	public IActionResult AddNewClass()
	{
		return View();
	}

	public IActionResult ClassesList()
	{
		return View();
	}

	public IActionResult ClassesSchedule()
	{
		return View();
	}

    public IActionResult Privacy()
    {
        return View();
    }
	public IActionResult SignIn()
	{
		return View();
	}

	public IActionResult SignUp()
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