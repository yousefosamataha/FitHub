using gms.common.Models.Identity.User;
using gms.service.Identity.GymRolesRepository;
using gms.service.Identity.GymUserRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class SuperAdminController : BaseController<SuperAdminController>
{
	private readonly IGymRolesService _gymRolesService;
	private readonly IGymUserService _gymUserService;

	public SuperAdminController(IGymRolesService gymRolesService, IGymUserService gymUserService)
	{
		_gymRolesService = gymRolesService;
		_gymUserService = gymUserService;
	}

	public async Task<IActionResult> GymUsers()
	{
		List<GymUserDTO> users = await _gymUserService.GetAllGymUserByGymIdAsync(GetGymId());
		return View(users);
	}
}
