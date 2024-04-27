using gms.common.Models.Identity;
using gms.data.Models.Identity;

namespace gms.service.TestUser;

public interface IGymUserService
{
    public Task<GymUserDto> UpdateGymUser(GymUserEntity entity);
}
