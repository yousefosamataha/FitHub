using gms.common.Models.GymCat.GymLocation;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymLocationRepository;

public interface IGymLocationService : IBaseRepository<GymLocationEntity>
{
    Task<bool> CreateNewGymLocationAsync(CreateGymLocationDTO createGymLocationModal);
    Task<List<GymLocationDTO>> GetGymLocationsListAsync();
    Task<bool> DeleteGymLocationAsync(int gymLocationId);
}
