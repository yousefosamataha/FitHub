using gms.common.Models.MembershipCat.MembershipPaymentHistory;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMembershipPaymentHistoryRepository;
public interface IGymMembershipPaymentHistoryService : IBaseRepository<GymMembershipPaymentHistoryEntity>
{
	Task<List<MembershipPaymentHistoryDTO>> GetMembershipPaymentListAsync();

	Task<MembershipPaymentHistoryDTO> CreateNewMembershipPaymentAsync(CreateMembershipPaymentHistoryDTO membershipPaymentDto);
}
