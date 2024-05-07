using gms.common.Models.Role;

namespace gms.service.GymRolesRepository;
public interface IGymRolesService
{
    Task<List<GymRoleDTO>> GetAllRolesAsync();

    Task<GymRolePermissionsDTO> GetRolePermissionsByRoleIdAsync(int roleId);

    Task<GymRoleDTO> CreateRoleAsync(string roleName);

    //GetAllGymPermissions();
}
