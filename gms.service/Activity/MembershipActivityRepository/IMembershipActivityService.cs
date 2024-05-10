using gms.common.Models.ActivityCat.MembershipActivity;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.MembershipActivityRepository;
public interface IMembershipActivityService : IBaseRepository<MembershipActivityEntity>
{
    Task<List<MembershipActivityDTO>> GetActivityMembershipsListAsync(int activityId);
    Task<bool> CreateNewMembershipActivityAsync(List<CreateMembershipActivityDTO> membershipActivitiesListDto);

    Task<bool> UpdateMembershipActivityAsync(List<CreateMembershipActivityDTO> updateMembershipActivitiesListDto, int activityId);
}
