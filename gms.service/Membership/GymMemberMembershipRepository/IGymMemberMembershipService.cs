using gms.common.Models.MembershipCat.MemberMembership;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMemberMembershipRepository;
public interface IGymMemberMembershipService : IBaseRepository<GymMemberMembershipEntity>
{
	Task<List<MemberMembershipDTO>> GetGymMemberMembershipListAsync();
	Task<MemberMembershipDTO> GetGymMemberMembershipByIdAsync(int memberMembershipId);
	Task<MemberMembershipDTO> CreateNewMemberMembershipAsync(CreateMemberMembershipDTO memberMembershipDto, int memberId);
	Task<MemberMembershipDTO> UpdateMemberMembershipAsync(UpdateMemberMembershipDTO updateMemberMembershipDto);
	Task<List<IGrouping<int, GymMemberMembershipEntity>>> GetNeedToReminderMemberShipListAsync();
}
