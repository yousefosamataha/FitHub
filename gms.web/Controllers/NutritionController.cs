using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class NutritionController : BaseController<NutritionController>
{
    public NutritionController()
    {
        
    }
    public IActionResult Index()
	{
		return View();
	}
}
