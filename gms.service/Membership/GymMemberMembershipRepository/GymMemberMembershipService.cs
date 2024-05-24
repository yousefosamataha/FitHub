using gms.common.Enums;
using gms.common.Models.MembershipCat.MemberMembership;
using gms.data;
using gms.data.Mapper.Membership;
using gms.data.Models.Membership;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace gms.service.Membership.GymMemberMembershipRepository;
public class GymMemberMembershipService : BaseRepository<GymMemberMembershipEntity>, IGymMemberMembershipService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public GymMemberMembershipService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public async Task<List<MemberMembershipDTO>> GetGymMemberMembershipListAsync()
	{
		List<GymMemberMembershipEntity> MemberMembershipList = await FindAllAsync(gmm => gmm.GymMemberUser.BranchId == GetBranchId(), ["GymMemberUser", "GymMembershipPlan", "MembershipPaymentHistories"]);
		return MemberMembershipList.Select(gmm => gmm.ToDTO()).ToList();
	}

    public async Task<MemberMembershipDTO> GetGymMemberMembershipByIdAsync(int memberMembershipId)
    {
        GymMemberMembershipEntity MemberMembership = await FindAsync(gmm => gmm.GymMemberUser.BranchId == GetBranchId() && gmm.Id == memberMembershipId, ["GymMemberUser", "GymMembershipPlan", "MembershipPaymentHistories"]);
        return MemberMembership.ToDTO();
    }

    public async Task<MemberMembershipDTO> CreateNewMemberMembershipAsync(CreateMemberMembershipDTO memberMembershipDto, int memberId)
    {
        GymMemberMembershipEntity newMemberMembershipEntity = memberMembershipDto.ToEntity();
        newMemberMembershipEntity.MemberId = memberId;
        newMemberMembershipEntity.MemberShipStatusId = StatusEnum.InActive;
        newMemberMembershipEntity.PaymentStatusId = StatusEnum.NotPaid;
        await AddAsync(newMemberMembershipEntity);
        return newMemberMembershipEntity.ToDTO();
    }

    public async Task<MemberMembershipDTO> UpdateMemberMembershipAsync(UpdateMemberMembershipDTO updateMemberMembershipDto)
    {
        GymMemberMembershipEntity currentMembershipMembershipEntity = await _context.GymMemberMemberships.FirstOrDefaultAsync(mm => mm.Id == updateMemberMembershipDto.Id);
        GymMemberMembershipEntity updatedMembershipMembershipEntity = updateMemberMembershipDto.ToUpdatedEntity(currentMembershipMembershipEntity);
        await UpdateAsync(updatedMembershipMembershipEntity);
        return updatedMembershipMembershipEntity.ToDTO();
    }
}
