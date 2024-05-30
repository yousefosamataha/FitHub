using gms.common.Models.GymCat.GymSpecialization;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymSpecializationRepository;

public interface IGymSpecializationService : IBaseRepository<GymSpecializationEntity>
{
	Task<bool> CreateNewGymSpecializationAsync(CreateGymSpecializationDTO createGymSpecializationModal);

	Task<List<GymSpecializationDTO>> GetGymSpecializationsListAsync();

	Task<bool> DeleteGymSpecializationAsync(int gymSpecializationId);
}