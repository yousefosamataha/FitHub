using gms.common.Models.MembershipCat.MembershipPlan;
using gms.data.Models.Membership;
using gms.services.Base;

namespace gms.service.Membership.GymMembershipPlanRepository;
public interface IGymMembershipPlanService : IBaseRepository<GymMembershipPlanEntity>
{
	Task<MembershipDTO> CreateGymMembershipPlanAsync(CreateMembershipDTO newMembership);
	Task<List<MembershipDTO>> GetMembershipPlansListAsync();
	Task<List<MembershipDTO>> GetActiveMembershipPlansListAsync();
	Task<MembershipDTO> GetMembershipAsync(int id);
	Task<MembershipDTO> UpdateGymMembershipPlanAsync(UpdateMembershipDTO membershipDTO);
	Task<bool> DeleteMembershipAsync(int id, int branchId);
}
