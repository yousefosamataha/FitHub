using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class MembershipController : BaseController<MembershipController>
{
	public IActionResult Index()
	{
		return View();
	}
}
