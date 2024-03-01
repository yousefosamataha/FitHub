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
}
