using gms.common.Models.MembershipCat.MemberMembership;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMemberMembershipRepository;
public interface IGymMemberMembershipService : IBaseRepository<GymMemberMembershipEntity>
{
	Task<List<MemberMembershipDTO>> GetGymMemberMembershipListAsync();

	Task<MemberMembershipDTO> CreateNewMemberMembershipAsync(CreateMemberMembershipDTO memberMembershipDto, int memberId);

	Task<List<GymMemberMembershipEntity>> GetNeedToReminderMemberShipListByReminderDaysAsync(int reminderDays);
}
