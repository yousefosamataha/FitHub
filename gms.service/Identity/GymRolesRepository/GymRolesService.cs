using gms.common.Constants;
using gms.common.Enums;
using gms.common.Models.Identity.Role;
using gms.common.Models.SharedCat;
using gms.data;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace gms.service.Identity.GymRolesRepository;
public class GymRolesService : IGymRolesService
{
	private readonly RoleManager<GymIdentityRoleEntity> _roleManager;
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	public GymRolesService(RoleManager<GymIdentityRoleEntity> roleManager, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
	{
		_roleManager = roleManager;
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public int GetUserId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("UserId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public int GetBranchId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("BranchId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public int GetGymId()
	{
		if (int.TryParse(_httpContextAccessor.HttpContext.User.FindFirst("GymId")?.Value, out int result))
			return result;
		else
			return 0;
	}

	public async Task<bool> IsRoleExistsAsync(string roleName)
	{
		return await _roleManager.RoleExistsAsync(roleName);
	}

	public async Task CreateRolesToBranchAsync(int branchId)
	{
		foreach (var role in Enum.GetValues(typeof(RolesEnum)))
		{
			GymIdentityRoleEntity newRole = new()
			{
				Name = role.ToString(),
				NormalizedName = role.ToString().ToUpper(),
				BranchId = branchId,
				IsDeleteable = false,
				IsUpdateable = false
			};
			await _roleManager.CreateAsync(newRole);

			if (string.Equals(role.ToString(), RolesEnum.GymOwner.ToString(), StringComparison.OrdinalIgnoreCase))
			{
				await AddAllPermissionClaimsAsync(newRole);
			}
		};
	}

	public async Task<GymIdentityRoleEntity> GetGymRoleByIdAsync(string roleId)
	{
		return await _roleManager.FindByIdAsync(roleId);
	}

	public async Task<List<GymRoleDTO>> GetAllRolesAsync()
	{
		List<GymRoleDTO> roles = await _roleManager.Roles.Where(r => r.BranchId == GetBranchId()).Select(r => new GymRoleDTO()
		{
			RoleId = r.Id,
			RoleName = r.Name
		}).ToListAsync();
		return roles;
	}

	public async Task<GymRolePermissionsDTO> GetRolePermissionsByRoleIdAsync(int roleId)
	{
		GymIdentityRoleEntity role = await _roleManager.FindByIdAsync(roleId.ToString());

		if (role is null)
			return new GymRolePermissionsDTO();

		List<string>? roleClaims = (await _roleManager.GetClaimsAsync(role)).Select(c => c.Value).ToList();

		List<SelectItemDTO> allClaims = PermissionsConstants.GenerateAllPermissionsList().Select(c => new SelectItemDTO()
		{
			Text = c
		}).ToList();

		foreach (SelectItemDTO claim in allClaims)
		{
			if (roleClaims.Any(c => string.Equals(c, claim.Text, StringComparison.OrdinalIgnoreCase)))
				claim.IsSelected = true;
		}

		GymRolePermissionsDTO result = new()
		{
			RoleId = role.Id,
			RoleName = role.Name,
			Permissions = allClaims.ToList()
		};

		return result;
	}

	public async Task<GymRoleDTO> CreateRoleAsync(CreateGymRoleDTO newRole)
	{
		GymIdentityRoleEntity newIdentityRoleEntity = newRole.ToEntity();
		newIdentityRoleEntity.BranchId = GetBranchId();
		newIdentityRoleEntity.IsDeleteable = true;
		newIdentityRoleEntity.IsUpdateable = true;
		await _roleManager.CreateAsync(newIdentityRoleEntity);
		return newIdentityRoleEntity.ToDTO();
	}

	public async Task<GymIdentityRoleEntity> AddAllPermissionClaimsAsync(GymIdentityRoleEntity role)
	{
		IList<Claim> allRoleClaims = await _roleManager.GetClaimsAsync(role);

		List<string> permissionList = PermissionsConstants.GenerateAllPermissionsList();

		foreach (string? permission in permissionList)
		{
			if (!allRoleClaims.Any(c => string.Equals(c.Type, PermissionsConstants.Permission, StringComparison.OrdinalIgnoreCase) &&
										string.Equals(c.Value, permission, StringComparison.OrdinalIgnoreCase))
								  )
			{
				await _roleManager.AddClaimAsync(role, new Claim(PermissionsConstants.Permission, permission));
			}
		}
		return role;
	}

	public async Task<GymIdentityRoleEntity> UpdateGymRolePermissionsAsync(GymIdentityRoleEntity role, List<string> permissionsList)
	{
		IList<Claim> allRoleClaims = await _roleManager.GetClaimsAsync(role);

		foreach (Claim claim in allRoleClaims)
			await _roleManager.RemoveClaimAsync(role, claim);

		List<Claim> roleNewClaims = permissionsList.Select(c => new Claim(PermissionsConstants.Permission.ToString(), c)).ToList();

		foreach (Claim newClaim in roleNewClaims)
			await _roleManager.AddClaimAsync(role, newClaim);

		return role;
	}


}
