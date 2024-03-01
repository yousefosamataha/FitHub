using gms.common.ViewModels;
using gms.service.GymUserRepository;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

public class SuperadminController : BaseController<SuperadminController>
{
	private readonly IGymUserService _gymUserService;
	public SuperadminController(IGymUserService gymUserService)
	{
		_gymUserService = gymUserService;
	}
	public async Task<IActionResult> GymUsers()
	{
		List<GymUserViewModel> users = await _gymUserService.GetAllUserByGymIdAsync();
		return View(users);

	}
	public async Task<IActionResult> GymUserRoles(string userId)
	{
		GymUserRolesViewModel user = await _gymUserService.GetUserRolesByUserIdAsync(userId);
		return View(user);
	}
	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> UpdateUserRoles(GymUserRolesViewModel userRoles)
	{
		GymUserRolesViewModel user = await _gymUserService.UpdateGymUserRolesAsyn(userRoles);
		return RedirectToAction(nameof(GymUsers));
	}
}
