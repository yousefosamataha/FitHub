using gms.common.Constants;
using gms.common.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace gms.service.GymRolesRepository;
public class GymRolesService : IGymRolesService
{
	private readonly RoleManager<IdentityRole> _roleManager;
	public GymRolesService(RoleManager<IdentityRole> roleManager)
	{
		_roleManager = roleManager;
	}

	public async Task<List<GymRoleViewModel>> GetAllRolesAsync()
	{
		List<GymRoleViewModel> roles = await _roleManager.Roles.Select(r => new GymRoleViewModel()
		{
			RoleId = r.Id,
			RoleName = r.Name
		}).ToListAsync();
		return roles;
	}

	public async Task<GymRolePermissionsViewModel> GetRolePermissionsByRoleIdAsync(string roleId)
	{
		IdentityRole role = await _roleManager.FindByIdAsync(roleId);
		if (role is null)
			return new GymRolePermissionsViewModel();

		List<string>? roleClaims = (await _roleManager.GetClaimsAsync(role)).Select(c => c.Value).ToList();
		List<SelectItemViewModel> allClaims = PermissionsConstants.GenerateAllPermissionsList().Select(c => new SelectItemViewModel()
		{
			Text = c
		}).ToList();
		foreach (SelectItemViewModel claim in allClaims)
		{
			if (roleClaims.Any(c => string.Equals(c, claim.Text, StringComparison.OrdinalIgnoreCase)))
				claim.IsSelected = true;
		}
		GymRolePermissionsViewModel result = new()
		{
			RoleId = role.Id,
			RoleName = role.Name,
			Permissions = allClaims.ToList()
		};
		return result;
	}
}
