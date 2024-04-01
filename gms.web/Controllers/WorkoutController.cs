using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class WorkoutController : BaseController<WorkoutController>
{
	public IActionResult Index()
	{
		return View();
	}
}
