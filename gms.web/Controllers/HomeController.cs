using gms.common.Models.Shared.Country;
using gms.data.Models.Identity;
using gms.service.Gym.GymBranchRepository;
using gms.service.Gym.GymRepository;
using gms.service.Shared.CountryRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using gms.service.Identity.GymUserRepository;

namespace gms.web.Controllers;

[Authorize]
public class HomeController : BaseController<HomeController>
{
	private readonly IGymService _gymService;
	private readonly IGymBranchService _gymBranchService;
	private readonly ICountryService _countryService;
    private readonly UserManager<GymUserEntity> _userManager;
	private readonly IGymUserService _gymUserService;

	public HomeController(IGymService gymService, IGymBranchService gymBranchService, ICountryService countryService, UserManager<GymUserEntity> userManager, IGymUserService gymUserService)
	{
		_gymService = gymService;
		_gymBranchService = gymBranchService;
		_countryService = countryService;
		_userManager = userManager;
		_gymUserService = gymUserService;
	}

	public async Task<IActionResult> Index()
	{
        System.Security.Claims.ClaimsPrincipal currentUser = this.User;
        var currentUserData =  await _userManager.GetUserAsync(currentUser);
        var test =  GetUserId();

        return View(currentUserData);
	}

    public IActionResult AddNewStaff()
    {
        return View();
    }

    public IActionResult StaffsList()
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

    [HttpGet]
    public IActionResult GetJsonlocalizer(string culture)
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", $"{culture}.json");
        string jsonContent = System.IO.File.ReadAllText(filePath);
		return Content(jsonContent, "application/json");
    }
}