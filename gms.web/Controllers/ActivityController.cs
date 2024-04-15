using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class ActivityController : BaseController<ActivityController>
{
	public IActionResult Index()
	{
		return View();
	}
}
