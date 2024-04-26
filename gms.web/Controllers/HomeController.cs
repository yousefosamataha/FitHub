using gms.common.Models.Shared.Country;
using gms.common.ViewModels;
using gms.data.Models.Identity;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.Shared.CountryRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class HomeController : BaseController<HomeController>
{
	private readonly IGymService _gymService;
	private readonly IGymBranchService _gymBranchService;
	private readonly ICountryService _countryService;
    private readonly UserManager<GymUserEntity> _userManager;

    public HomeController(IGymService gymService, IGymBranchService gymBranchService, ICountryService countryService, UserManager<GymUserEntity> userManager)
    {
        _gymService = gymService;
        _gymBranchService = gymBranchService;
        _countryService = countryService;
        _userManager = userManager;
    }

    public IActionResult Index()
	{
        System.Security.Claims.ClaimsPrincipal currentUser = this.User;
        var test = _userManager.GetUserAsync(currentUser);

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

	public async Task<IActionResult> SignUp()
	{
		List<CountryDTO> List = await _countryService.GetCountriesListAsync();

        return View(List);
	}

    [HttpGet]
	[AllowAnonymous]
    public async Task<List<CountryDTO>> GetCountriesList()
    {
        List<CountryDTO> List = await _countryService.GetCountriesListAsync();

        return List;
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