using gms.common.Models.Identity;
using gms.data.Models.Identity;

namespace gms.service.TestUser;

public interface IGymUserService
{
    Task<GymUserDTO> UpdateGymUser(GymUserEntity entity);
    Task<GymUserEntity> GetGymUserByEmail(string email);
}
