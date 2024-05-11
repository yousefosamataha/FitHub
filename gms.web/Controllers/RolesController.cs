using gms.common.Models.Identity.Role;
using gms.data.Models.Identity;
using gms.service.Identity.GymRolesRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gms.web.Controllers;

[Authorize]
public class RolesController : BaseController<RolesController>
{
	private readonly IGymRolesService _gymRolesService;

	public RolesController(IGymRolesService gymRolesService)
	{
		_gymRolesService = gymRolesService;
	}

	public async Task<IActionResult> Index()
	{
		List<GymRoleDTO> roles = await _gymRolesService.GetAllRolesAsync();
		return View(roles);
	}

	public async Task<IActionResult> GymRolePermissionsByRoleId(int roleId)
	{
		GymRolePermissionsDTO result = await _gymRolesService.GetRolePermissionsByRoleIdAsync(roleId);
		return View(result);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> AddGymRole(CreateGymRoleDTO newRole)
	{
		if (!ModelState.IsValid)
			return View(nameof(Index), await _gymRolesService.GetAllRolesAsync());

		if (await _gymRolesService.IsRoleExistsAsync(newRole.RoleName))
		{
			ModelState.AddModelError("RoleName", "Role Already Exists");
			return View(nameof(Index), await _gymRolesService.GetAllRolesAsync());
		}

		await _gymRolesService.CreateRoleAsync(newRole);

		return RedirectToAction(nameof(Index));
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> UpdateRolePermissions(GymRolePermissionsDTO rolePermissions)
	{
		GymIdentityRoleEntity role = await _gymRolesService.GetGymRoleByIdAsync(rolePermissions.RoleId.ToString());

		if (role is null)
			return NotFound();

		List<string> roleNewPermissions = rolePermissions.Permissions.Where(c => c.IsSelected).Select(c => c.Text).ToList();

		await _gymRolesService.UpdateGymRolePermissionsAsync(role, roleNewPermissions);

		return RedirectToAction(nameof(Index));
	}
}
