using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class ActivityController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
