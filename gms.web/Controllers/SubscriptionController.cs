using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class SubscriptionController : BaseController<SubscriptionController>
{
	public SubscriptionController()
	{

	}
	public IActionResult Index()
	{
		return View();
	}
}
