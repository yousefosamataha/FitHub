using gms.common.ViewModels;

namespace gms.service.GymUserRepository;
public interface IGymUserService
{
    Task<List<GymUserViewModel>> GetAllUserByGymIdAsync();
    Task<GymUserRolesViewModel> GetUserRolesByUserIdAsync(string userId);
    Task<GymUserRolesViewModel> UpdateGymUserRolesAsyn(GymUserRolesViewModel gymUserRoles);
}
