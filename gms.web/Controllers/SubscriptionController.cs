using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class SubscriptionController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
