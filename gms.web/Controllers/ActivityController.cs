using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class ActivityController : BaseController<ActivityController>
{
	public IActionResult Index()
	{
		return View();
	}
}
