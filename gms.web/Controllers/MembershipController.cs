using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class MembershipController : BaseController<MembershipController>
{
    public MembershipController()
    {
        
    }
    public IActionResult Index()
	{
		return View();
	}
}
