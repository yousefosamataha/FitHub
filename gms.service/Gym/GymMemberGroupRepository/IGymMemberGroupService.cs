using gms.common.Models.GymCat.GymMemberGroup;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.GymMemberGroupRepository;

public interface IGymMemberGroupService : IBaseRepository<GymMemberGroupEntity>
{
    Task<bool> CreateNewGymMemberGroupAsync(List<CreateGymMemberGroupDTO> GymMemberGroupsListDto);
    Task<List<GymMemberGroupDTO>> GetGymMemberGroupsListAsync(int memberId);
    Task<bool> UpdateGymMemberGroupAsync(List<CreateGymMemberGroupDTO> updateGymMemberGroupsListDto, int memberId);
}
