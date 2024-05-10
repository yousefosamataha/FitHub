using gms.common.Models.GymCat.GymLocation;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymLocationRepository;

public interface IGymLocationService : IBaseRepository<GymLocationEntity>
{
    Task<List<GymLocationDTO>> GetGymLocationsListAsync();
}
