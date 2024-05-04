using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class StaffController : BaseController<StaffController>
{
    public StaffController()
    {
        
    }
    public IActionResult Index()
	{
		return View();
	}
}
