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
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(RolesController), nameof(Index), "HttpGet", DateTime.Now.ToString() });

			List<GymRoleDTO> roles = await _gymRolesService.GetAllRolesAsync();
			return View(roles);
		}

	}

	public async Task<IActionResult> GymRolePermissionsByRoleId(int roleId)
	{

		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(RolesController), nameof(GymRolePermissionsByRoleId), "HttpGet", DateTime.Now.ToString() });

			GymRolePermissionsDTO result = await _gymRolesService.GetRolePermissionsByRoleIdAsync(roleId);
			return View(result);
		}

	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> AddGymRole(CreateGymRoleDTO newRole)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(RolesController), nameof(AddGymRole), "HttpPost", DateTime.Now.ToString() });

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

	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> UpdateRolePermissions(GymRolePermissionsDTO rolePermissions)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(RolesController), nameof(UpdateRolePermissions), "HttpPost", DateTime.Now.ToString() });

			GymIdentityRoleEntity role = await _gymRolesService.GetGymRoleByIdAsync(rolePermissions.RoleId.ToString());

			if (role is null)
				return NotFound();

			List<string> roleNewPermissions = rolePermissions.Permissions.Where(c => c.IsSelected).Select(c => c.Text).ToList();

			await _gymRolesService.UpdateGymRolePermissionsAsync(role, roleNewPermissions);

			return RedirectToAction(nameof(Index));
		}

	}


	public IActionResult Roles()
	{
		return View();
	}

	public IActionResult Permissions()
	{
		return View();
	}
}
