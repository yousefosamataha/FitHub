using gms.common.ViewModels;

namespace gms.service.GymRolesRepository;
public interface IGymRolesService
{
	Task<List<GymRoleViewModel>> GetAllRolesAsync();
	Task<GymRolePermissionsViewModel> GetRolePermissionsByRoleIdAsync(string roleId);
	//GetAllGymPermissions();
}
