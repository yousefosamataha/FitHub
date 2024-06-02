using gms.common.Models.Identity.Role;
using gms.common.Models.IdentityCat.Role;
using gms.data.Models.Identity;

namespace gms.service.Identity.GymRolesRepository;

public interface IGymRolesService
{
	Task<bool> IsRoleExistsAsync(string roleName);

	Task CreateRolesForBranchAsync(int branchId);

	Task<GymIdentityRoleEntity> GetGymRoleByIdAsync(string roleId);

	Task<List<GymRoleDTO>> GetAllRolesAsync();

	Task<GymRolePermissionsDTO> GetRolePermissionsByRoleIdAsync(int roleId);

	Task<GymRoleDTO> CreateRoleAsync(CreateGymRoleDTO role);

	Task<GymIdentityRoleEntity> AddAllPermissionClaimsAsync(GymIdentityRoleEntity role);

	Task<bool> CreateRoleAndPermissionsAsync(CreateGymRoleDTO newRole, List<string> permissionsList);

    Task<GymIdentityRoleEntity> UpdateGymRolePermissionsAsync(GymIdentityRoleEntity role, List<string> permissionsList);

	Task<GymRoleDTO> UpdateRoleAsync(UpdateGymRoleDTO updateRole);

	Task<bool> DeleteRoleAsync(int roleId);
}
