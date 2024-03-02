using gms.common.ViewModels;
using gms.service.GymRolesRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
	public async Task<IActionResult> GymRolePermissionsByRoleId(string roleId)
	{
		GymRolePermissionsViewModel result = await _gymRolesService.GetRolePermissionsByRoleIdAsync(roleId);
		return View(result);
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

		return RedirectToAction(nameof(GymRoles));
	}

	public async Task<IActionResult> UpdateRolePermissions(GymRolePermissionsViewModel rolePermissions)
	{
		IdentityRole role = await _roleManager.FindByIdAsync(rolePermissions.RoleId);

		if (role is null)
			return NotFound();

		IList<Claim> roleClaims = await _roleManager.GetClaimsAsync(role);

		foreach (Claim claim in roleClaims)
			await _roleManager.RemoveClaimAsync(role, claim);

		List<Claim> roleNewClaims = rolePermissions.Permissions.Where(c => c.IsSelected).Select(c => new Claim(PermissionsConstants.Permission.ToString(), c.Text)).ToList();
		foreach (Claim newClaim in roleNewClaims)
			await _roleManager.AddClaimAsync(role, newClaim);

		return RedirectToAction(nameof(GymRoles));
	}
}
