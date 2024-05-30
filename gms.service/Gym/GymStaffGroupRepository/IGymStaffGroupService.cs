using gms.common.Models.GymCat.GymStaffGroup;
using gms.data.Models.Gym;
using gms.services.Base;

namespace gms.service.Gym.StaffGroupRepository;

public interface IGymStaffGroupService : IBaseRepository<GymStaffGroupEntity>
{
	Task<bool> CreateNewGymStaffGroupAsync(List<CreateGymStaffGroupDTO> gymStaffGroupsListDto);
	Task<bool> UpdateGymStaffGroupAsync(List<CreateGymStaffGroupDTO> updateGymStaffGroupsListDto, int staffId);
}
