using gms.common.Enums;
using gms.common.Models.MembershipCat.MembershipPlan;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Mapper.Membership;
using gms.data.Models.Gym;
using gms.data.Models.Membership;
using gms.service.Gym.GymBranchRepository;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace gms.service.Membership.GymMembershipPlanRepository;
public class GymMembershipPlanService : BaseRepository<GymMembershipPlanEntity>, IGymMembershipPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IGymBranchService _gymBranchService;

    public GymMembershipPlanService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, IGymBranchService gymBranchService) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
        _gymBranchService = gymBranchService;
    }

    public async Task<MembershipDTO> CreateGymMembershipPlanAsync(CreateMembershipDTO newMembership)
	{
		GymMembershipPlanEntity newMembershipEntity = newMembership.ToEntity();
        newMembershipEntity.BranchId = GetBranchId();
        await AddAsync(newMembershipEntity);
		return newMembershipEntity.ToDTO();
	}

	public async Task<List<MembershipDTO>> GetMembershipPlansListAsync()
	{
        GymBranchEntity branchData = await _gymBranchService.FindAsync(gb => gb.Id == GetBranchId(), ["Country"]);
        List<GymMembershipPlanEntity> listOfMembership = await FindAllAsync(mp => mp.BranchId == GetBranchId());
        return listOfMembership.Select(mp => mp.ToDTO(branchData.Country.TimezoneOffset)).ToList();
	}

	public async Task<List<MembershipDTO>> GetActiveMembershipPlansListAsync()
	{
		List<GymMembershipPlanEntity> listOfMembership = await FindAllAsync(mp => mp.BranchId == GetBranchId() && mp.MembershipStatusId == StatusEnum.Active);
		return listOfMembership.Select(mp => mp.ToDTO()).ToList();
	}

	public async Task<MembershipDTO> GetMembershipAsync(int id)
    {
        var MembershipEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == GetBranchId());
        return MembershipEntity.ToDTO();
    }

	public async Task<MembershipDTO> UpdateGymMembershipPlanAsync(UpdateMembershipDTO updatemembershipDTO)
	{
		GymMembershipPlanEntity currentMembershipEntity = await _context.GymMembershipPlans.FirstOrDefaultAsync(mp => mp.Id == updatemembershipDTO.Id);
		GymMembershipPlanEntity updatedMembershipEntity = updatemembershipDTO.ToUpdatedEntity(currentMembershipEntity);
		await UpdateAsync(updatedMembershipEntity);
		return updatedMembershipEntity.ToDTO();
	}

    public async Task<bool> DeleteMembershipAsync(int id, int branchId)
    {
        var MembershipEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == branchId);
        await DeleteAsync(MembershipEntity);
        return true;
    }
}

