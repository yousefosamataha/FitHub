using gms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Diagnostics;

namespace gms.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly IStringLocalizer<HomeController> _localizer;
		public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer) 
		{
			_logger = logger;
			_localizer = localizer;
		}

		public IActionResult Index()
		{
			ViewBag.WelcomeMessage = _localizer["welcome"];
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}