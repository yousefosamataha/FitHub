using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class SubscriptionController : BaseController<SubscriptionController>
{
	public IActionResult Index()
	{
		return View();
	}
}
