using gms.common.Models.ActivityCat.MembershipActivity;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.MembershipActivityRepository;
public interface IMembershipActivityService : IBaseRepository<MembershipActivityEntity>
{
	Task<bool> CreateNewMembershipActivityAsync(List<CreateMembershipActivityDTO> membershipActivitiesListDto);
}
