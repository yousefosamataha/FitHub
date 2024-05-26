using gms.common.Enums;
using gms.common.Models.Identity.Role;
using gms.common.Models.SharedCat;
using gms.common.Permissions;
using gms.data;
using gms.data.Mapper.Identity;
using gms.data.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace gms.service.Identity.GymRolesRepository;
public class GymRolesService : IGymRolesService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly RoleManager<GymIdentityRoleEntity> _roleManager;
	private readonly ILogger<GymRolesService> _logger;
	public GymRolesService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		RoleManager<GymIdentityRoleEntity> roleManager,  
		ILogger<GymRolesService> logger
	)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_roleManager = roleManager;
		_logger = logger;
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
	public Dictionary<string, object> GetScopesInformation()
	{
		Dictionary<string, object> scopeInfo = new();
		scopeInfo.Add("MachineName", Environment.MachineName);
		scopeInfo.Add("Environment", "Development");
		scopeInfo.Add("AppName", "Logging Scopes");
		scopeInfo.Add("GymId", GetGymId());
		scopeInfo.Add("BranchId", GetBranchId());
		scopeInfo.Add("UserId", GetUserId());
		return scopeInfo;
	}

	public async Task<bool> IsRoleExistsAsync(string roleName)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(IsRoleExistsAsync), DateTime.Now.ToString() });
		}
		return await _roleManager.RoleExistsAsync(roleName);
	}

	public async Task CreateRolesForBranchAsync(int branchId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(CreateRolesForBranchAsync), DateTime.Now.ToString() });

			foreach (var role in Enum.GetValues(typeof(RolesEnum)))
			{
				string roleName = $"{branchId}_{role}";
				GymIdentityRoleEntity newRole = new()
				{
					Name = roleName,
					NormalizedName = roleName.ToUpper(),
					BranchId = branchId,
					IsDeleteable = false,
					IsUpdateable = false
				};
				await _roleManager.CreateAsync(newRole);

				if (string.Equals(role.ToString(), RolesEnum.Owner.ToString(), StringComparison.OrdinalIgnoreCase))
				{
					await AddAllPermissionClaimsAsync(newRole);
				}
			};
		}
		
	}

	public async Task<GymIdentityRoleEntity> GetGymRoleByIdAsync(string roleId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(GetGymRoleByIdAsync), DateTime.Now.ToString() });

			return await _roleManager.FindByIdAsync(roleId);
		}
		
	}

	public async Task<List<GymRoleDTO>> GetAllRolesAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(GetAllRolesAsync), DateTime.Now.ToString() });

			List<GymRoleDTO> roles = await _roleManager.Roles.Where(r => r.BranchId == GetBranchId()).Select(r => r.ToDTO()).ToListAsync();
			return roles;
		}
		
	}

	public async Task<GymRolePermissionsDTO> GetRolePermissionsByRoleIdAsync(int roleId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(GetRolePermissionsByRoleIdAsync), DateTime.Now.ToString() });

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
		
	}

	public async Task<GymRoleDTO> CreateRoleAsync(CreateGymRoleDTO newRole)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(CreateRoleAsync), DateTime.Now.ToString() });

			GymIdentityRoleEntity newIdentityRoleEntity = newRole.ToEntity(GetBranchId());
			await _roleManager.CreateAsync(newIdentityRoleEntity);
			return newIdentityRoleEntity.ToDTO();
		}
		
	}

	public async Task<GymIdentityRoleEntity> AddAllPermissionClaimsAsync(GymIdentityRoleEntity role)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(AddAllPermissionClaimsAsync), DateTime.Now.ToString() });

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
		
	}

	public async Task<GymIdentityRoleEntity> UpdateGymRolePermissionsAsync(GymIdentityRoleEntity role, List<string> permissionsList)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymRolesService), nameof(UpdateGymRolePermissionsAsync), DateTime.Now.ToString() });

			IList<Claim> allRoleClaims = await _roleManager.GetClaimsAsync(role);

			foreach (Claim claim in allRoleClaims)
				await _roleManager.RemoveClaimAsync(role, claim);

			List<Claim> roleNewClaims = permissionsList.Select(c => new Claim(PermissionsConstants.Permission.ToString(), c)).ToList();

			foreach (Claim newClaim in roleNewClaims)
				await _roleManager.AddClaimAsync(role, newClaim);

			return role;
		}
		
	}
}
