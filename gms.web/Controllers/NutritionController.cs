using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class NutritionController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
