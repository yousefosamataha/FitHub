using gms.common.Models.MembershipCat;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Mapper.Membership;
using gms.data.Models.Membership;
using gms.service.Gym.GymBranchRepository;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
		await AddAsync(newMembershipEntity);
		return newMembershipEntity.ToDTO();
	}

	public async Task<List<MembershipDTO>> GetMembershipPlansListAsync(int branchId)
	{
        var branchData = await _gymBranchService.FindAsync(gb => gb.Id == branchId, ["Country"]);
        var branchTimezoneOffset = int.Parse(branchData.Country.TimezoneOffset, System.Globalization.CultureInfo.InvariantCulture);
        List<GymMembershipPlanEntity> listOfMembership = await FindAllAsync(mp => mp.BranchId == branchId);
        return listOfMembership.Select(mp => new MembershipDTO() 
        { 
            Id = mp.Id,
            BranchId = mp.BranchId,
            MembershipName = mp.MembershipName,
            MembershipDuration = mp.MembershipDuration,
            MembershipDurationTypeId = mp.MembershipDurationTypeId,
            MembershipAmount = mp.MembershipAmount,
            MembershipStatusId = mp.MembershipStatusId,
            SignupFee = mp.SignupFee,
            MembershipDescription = mp.MembershipDescription,
            ClassIsLimit = mp.ClassIsLimit,
            ClassLimitDays = mp.ClassLimitDays,
            ClassLimitationId = mp.ClassLimitationId,
            CreatedById = mp.CreatedById,
            CreatedAt = mp.CreatedAt.AddHours(branchTimezoneOffset),
        }).ToList();
	}

    public async Task<MembershipDTO> GetMembershipAsync(int id, int branchId)
    {
        var MembershipEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == branchId);
        return MembershipEntity.ToDTO();
    }

	public async Task<MembershipDTO> UpdateGymMembershipPlanAsync(MembershipDTO updatemembershipDTO)
	{
		GymMembershipPlanEntity currentMembershipEntity = await _context.GymMembershipPlans.FirstOrDefaultAsync(mp => mp.Id == updatemembershipDTO.Id);
		GymMembershipPlanEntity updatedMembershipEntity = updatemembershipDTO.ToUpdatedEntity(currentMembershipEntity);
		await UpdateAsync(updatedMembershipEntity);
		return updatedMembershipEntity.ToDTO();
	}

    public async Task<IActionResult> DeleteMembershipAsync(int id, int branchId)
    {
        var MembershipEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == branchId);
        await DeleteAsync(MembershipEntity);
        return new OkResult();
    }
}

