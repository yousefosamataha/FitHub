using gms.common.Models.Role;
using gms.data.Models.Identity;

namespace gms.service.Identity.GymRolesRepository;
public interface IGymRolesService
{
	Task CreateRolesToBranch(int branchId);
	Task<List<GymRoleDTO>> GetAllRolesAsync();
	Task<GymRolePermissionsDTO> GetRolePermissionsByRoleIdAsync(int roleId);
	Task<GymRoleDTO> CreateRoleAsync(CreateGymRoleDTO role);
	Task<GymIdentityRoleEntity> AddAllPermissionClaims(GymIdentityRoleEntity role);
}
