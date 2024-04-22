using gms.common.Models.Gym;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymRepository;
public interface IGymService : IBaseRepository<GymEntity>
{
    Task<GymDTO> CreateGym(CreateGymDTO newGym);
}
