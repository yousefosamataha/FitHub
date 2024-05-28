using gms.common.Models.GymCat.GymStaffSpecialization;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymStaffSpecializationRepository;

public interface IGymStaffSpecializationService : IBaseRepository<GymStaffSpecializationEntity>
{
    Task<bool> CreateNewGymStaffSpecializationAsync(List<CreateGymStaffSpecializationDTO> gymStaffSpecializationsListDto);

    Task<bool> UpdateGymStaffSpecializationAsync(List<CreateGymStaffSpecializationDTO> updateGymStaffSpecializationsListDto, int staffId);
}
