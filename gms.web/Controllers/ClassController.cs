using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class ClassController : BaseController<ClassController>
{
	public IActionResult Index()
	{
		return View();
	}
}
