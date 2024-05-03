using gms.common.Models.MembershipCat;
using gms.data.Models.Membership;
using gms.services.Base;
using Microsoft.AspNetCore.Mvc;

namespace gms.service.Membership.GymMembershipPlanRepository;
public interface IGymMembershipPlanService : IBaseRepository<GymMembershipPlanEntity>
{
	Task<MembershipDTO> CreateGymMembershipPlanAsync(CreateMembershipDTO newMembership);
	Task<List<MembershipDTO>> GetMembershipPlansListAsync(int branchId);
	Task<MembershipDTO> GetMembershipAsync(int id,int branchId);
	Task<MembershipDTO> UpdateGymMembershipPlanAsync(MembershipDTO membershipDTO);
	Task<IActionResult> DeleteMembershipAsync(int id, int branchId);
}
