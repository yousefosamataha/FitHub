using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class StaffController : BaseController<StaffController>
{
	public IActionResult Index()
	{
		return View();
	}
}
