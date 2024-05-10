using gms.common.Models.Identity;
using gms.common.Models.IdentityCat;
using gms.common.Models.Role;
using gms.common.ViewModels;
using gms.data.Models.Identity;

namespace gms.service.Identity.GymUserRepository;
public interface IGymUserService
{
    Task<List<GymUserViewModel>> GetAllUserByGymIdAsync();
    Task<GymUserRolesDTO> GetUserRolesByUserIdAsync(int userId);
    Task<GymUserRolesDTO> UpdateGymUserRolesAsyn(GymUserRolesDTO gymUserRoles);


    Task<GymUserDTO> UpdateGymUser(GymUserEntity entity);
    Task<GymUserEntity> GetGymUserByEmail(string email);
    Task<GymUserDTO> AddGymUserMemberAsync(CreateGymUserDTO entity);
}
