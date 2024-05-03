using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class ClassController : BaseController<ClassController>
{
    public ClassController()
    {
        
    }
    public IActionResult Index()
	{
		return View();
	}


	public IActionResult AddNewClass()
	{
		return View();
	}

	public IActionResult ClassesList()
	{
		return View();
	}

	public IActionResult ClassesSchedule()
	{
		return View();
	}
}
