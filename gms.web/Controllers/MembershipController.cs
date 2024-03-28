using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class MembershipController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
