using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class StaffController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
