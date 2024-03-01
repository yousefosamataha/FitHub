using gms.common.ViewModels;
using gms.service.GymRolesRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;
public class RolesController : BaseController<RolesController>
{
	private readonly IGymRolesService _gymRolesService;
	private readonly RoleManager<IdentityRole> _roleManager;
	public RolesController(IGymRolesService gymRolesService, RoleManager<IdentityRole> roleManager)
	{
		_gymRolesService = gymRolesService;
		_roleManager = roleManager;
	}
	public async Task<IActionResult> GymRoles()
	{
		List<GymRoleViewModel> roles = await _gymRolesService.GetAllRolesAsync();
		return View(roles);
	}
	public async Task<IActionResult> GymRolePermissions(string roleId)
	{
		return View();
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> AddGymRole(AddRoleViewModel newRole)
	{
		if (!ModelState.IsValid)
			return View("GymRoles", await _gymRolesService.GetAllRolesAsync());
		if (await _roleManager.RoleExistsAsync(newRole.RoleName))
		{
			ModelState.AddModelError("RoleName", "Role Already Exists");
			return View("GymRoles", await _gymRolesService.GetAllRolesAsync());
		}
		await _roleManager.CreateAsync(new IdentityRole(newRole.RoleName.Trim()));

		return RedirectToAction("GymRoles");
	}
}
