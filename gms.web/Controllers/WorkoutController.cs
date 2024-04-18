using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class WorkoutController : BaseController<WorkoutController>
{
    public WorkoutController()
    {
        
    }
    public IActionResult Index()
	{
		return View();
	}
}
