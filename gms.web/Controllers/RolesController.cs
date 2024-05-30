using gms.common.Models.Identity.Role;
using gms.common.Models.IdentityCat.Role;
using gms.common.Models.SharedCat;
using gms.common.Permissions;
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


    [HttpGet]
    public IActionResult AddRole()
    {
        using (logger.BeginScope(GetScopesInformation()))
        {
            logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
                                  new object[] { nameof(RolesController), nameof(AddRole), "HttpPost", DateTime.Now.ToString() });
			GymRolePermissionsDTO modal = new()
			{
                Permissions = PermissionsConstants.GenerateAllPermissionsList().Select(c => new SelectItemDTO()
                {
                    Text = c,
                    IsSelected = false
                }).ToList()
            };

            return PartialView("_AddRole", modal);
        }
    }


    [HttpPost]
	public async Task<IActionResult> AddRole(GymRolePermissionsDTO newRolePermission)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(RolesController), nameof(AddRole), "HttpPost", DateTime.Now.ToString() });

			CreateGymRoleDTO newRole = new()
			{
				RoleName = newRolePermission.RoleName
			};
            List<string> roleNewPermissions = newRolePermission.Permissions.Where(c => c.IsSelected).Select(c => c.Text).ToList();


            await _gymRolesService.CreateRoleAndPermissionsAsync(newRole, roleNewPermissions);

			return RedirectToAction(nameof(Index));
		}
	}

    [HttpGet]
    public async Task<IActionResult> EditRole(int roleId)
    {

        using (logger.BeginScope(GetScopesInformation()))
        {
            logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
                                  new object[] { nameof(RolesController), nameof(EditRole), "HttpGet", DateTime.Now.ToString() });

            GymRolePermissionsDTO modal = await _gymRolesService.GetRolePermissionsByRoleIdAsync(roleId);
            return PartialView("_EditRole", modal);
        }

    }

    [HttpPost]
	public async Task<IActionResult> EditRole(GymRolePermissionsDTO rolePermissions)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(RolesController), nameof(EditRole), "HttpPost", DateTime.Now.ToString() });

            UpdateGymRoleDTO updateRoleDTO = new () {
                RoleId = rolePermissions.RoleId,
				RoleName = $"{GetBranchId()}_{rolePermissions.RoleName}"
            };

            GymRoleDTO UpdatedRole = await _gymRolesService.UpdateRoleAsync(updateRoleDTO);
            GymIdentityRoleEntity role = await _gymRolesService.GetGymRoleByIdAsync(UpdatedRole.RoleId.ToString());

			if (role is null)
				return NotFound();

            List<string> roleNewPermissions = rolePermissions.Permissions.Where(c => c.IsSelected).Select(c => c.Text).ToList();

			await _gymRolesService.UpdateGymRolePermissionsAsync(role, roleNewPermissions);

			return RedirectToAction(nameof(Index));
		}

	}

	[HttpPost]
	public async Task<JsonResult> DeleteRole(int roleId)
	{
		using (logger.BeginScope(GetScopesInformation()))
		{
			logger.LogInformation("Request Received by Controller: {Controller}, Action: {ControllerAction}, HttpMethod: {Method}, DateTime: {DateTime}",
								  new object[] { nameof(RolesController), nameof(DeleteRole), "HttpPost", DateTime.Now.ToString() });

			GymIdentityRoleEntity role = await _gymRolesService.GetGymRoleByIdAsync(roleId.ToString());
			if (role.IsDeleteable)
			{
				await _gymRolesService.DeleteRoleAsync(roleId);
				return Json(new { Success = true, Message = "" });
			}

			return Json(new { Success = false, Message = "" });
		}

	}
}
