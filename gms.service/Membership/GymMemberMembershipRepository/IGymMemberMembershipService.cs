using gms.common.Models.MembershipCat.MemberMembership;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMemberMembershipRepository;
public interface IGymMemberMembershipService : IBaseRepository<GymMemberMembershipEntity>
{
    Task<MemberMembershipDTO> CreateNewMemberMembershipAsync(CreateMemberMembershipDTO memberMembershipDto, int memberId);
}
