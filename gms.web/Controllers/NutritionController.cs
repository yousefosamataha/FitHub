using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class NutritionController : BaseController<NutritionController>
{
	public IActionResult Index()
	{
		return View();
	}
}
