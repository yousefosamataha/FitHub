using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class WorkoutController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
