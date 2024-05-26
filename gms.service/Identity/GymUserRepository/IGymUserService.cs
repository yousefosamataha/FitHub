using gms.common.Models.Identity.Role;
using gms.common.Models.Identity.User;
using gms.common.Models.IdentityCat.User;
using gms.data.Models.Identity;

namespace gms.service.Identity.GymUserRepository;

public interface IGymUserService
{
	Task<List<GymUserDTO>> GetAllGymUserByGymIdAsync(int gymId);

	Task<List<GymUserDTO>> GetAllGymBranchUsersByBranchIdAsync(int gymId, int branchId);

	Task<GymUserRolesDTO> GetUserRolesByUserIdAsync(int userId);

	Task<GymUserRolesDTO> UpdateGymUserRolesAsyn(UpdateGymUserRolesDTO gymUserRoles);

	Task<GymUserDTO> UpdateGymUser(GymUserEntity entity);

	Task<GymUserEntity> GetGymUserByEmail(string email);

	Task<GymUserEntity> GetGymUserByIdAsync(int userId);

    Task<GymUserDTO> CreateNewGymMemberUserAsync(CreateGymUserDTO entity, int branchId);

	Task<List<GymUserDTO>> GetGymMemberUsersListAsync();

	Task<GymUserDTO> UpdateGymMemberUserAsync(UpdateGymUserDTO entity);

	Task<GymUserDTO> CreateNewGymStaffUserAsync(CreateGymUserDTO entity, int branchId, string RoleName);

	Task<List<GymUserDTO>> GetGymStaffUsersListAsync();
}
