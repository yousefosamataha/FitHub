using gms.common.Models.Identity;
using gms.common.Models.IdentityCat;
using gms.common.ViewModels;
using gms.data.Models.Identity;

namespace gms.service.GymUserRepository;
public interface IGymUserService
{
    Task<List<GymUserViewModel>> GetAllUserByGymIdAsync();
    Task<GymUserRolesViewModel> GetUserRolesByUserIdAsync(int userId);
    Task<GymUserRolesViewModel> UpdateGymUserRolesAsyn(GymUserRolesViewModel gymUserRoles);


    Task<GymUserDTO> UpdateGymUser(GymUserEntity entity);
    Task<GymUserEntity> GetGymUserByEmail(string email);
    Task<GymUserDTO> AddGymUserMemberAsync(CreateGymUserDTO entity);
}
