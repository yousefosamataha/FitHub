using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class ClassController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
