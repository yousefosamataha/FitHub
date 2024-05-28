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
using Microsoft.Extensions.Logging;

namespace gms.service.Membership.GymMembershipPlanRepository;
public class GymMembershipPlanService : BaseRepository<GymMembershipPlanEntity>, IGymMembershipPlanService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IGymBranchService _gymBranchService;
	private readonly ILogger<GymMembershipPlanService> _logger;
	public GymMembershipPlanService
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor,
		IGymBranchService gymBranchService, 
		ILogger<GymMembershipPlanService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_gymBranchService = gymBranchService;
		_logger = logger;
	}

	public async Task<MembershipDTO> CreateGymMembershipPlanAsync(CreateMembershipDTO newMembership)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMembershipPlanService), nameof(CreateGymMembershipPlanAsync), DateTime.Now.ToString() });

			GymMembershipPlanEntity newMembershipEntity = newMembership.ToEntity();
			newMembershipEntity.BranchId = GetBranchId();
			await AddAsync(newMembershipEntity);
			return newMembershipEntity.ToDTO();
		}
		
	}

	public async Task<List<MembershipDTO>> GetMembershipPlansListAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMembershipPlanService), nameof(GetMembershipPlansListAsync), DateTime.Now.ToString() });

			GymBranchEntity branchData = await _gymBranchService.FindAsync(gb => gb.Id == GetBranchId(), ["Country"]);
			List<GymMembershipPlanEntity> listOfMembership = await FindAllAsync(mp => mp.BranchId == GetBranchId());
			return listOfMembership.Select(mp => mp.ToDTO(branchData.Country.TimezoneOffset)).ToList();
		}
			
	}

	public async Task<List<MembershipDTO>> GetActiveMembershipPlansListAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMembershipPlanService), nameof(GetActiveMembershipPlansListAsync), DateTime.Now.ToString() });

			List<GymMembershipPlanEntity> listOfMembership = await FindAllAsync(mp => mp.BranchId == GetBranchId() && mp.MembershipStatusId == StatusEnum.Active);
			return listOfMembership.Select(mp => mp.ToDTO()).ToList();
		}
		
	}

	public async Task<MembershipDTO> GetMembershipByIdAsync(int id)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMembershipPlanService), nameof(GetMembershipByIdAsync), DateTime.Now.ToString() });

			GymMembershipPlanEntity MembershipEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == GetBranchId());
			return MembershipEntity.ToDTO();
		}
		
    }

	public async Task<MembershipDTO> UpdateGymMembershipPlanAsync(UpdateMembershipDTO updatemembershipDTO)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMembershipPlanService), nameof(UpdateGymMembershipPlanAsync), DateTime.Now.ToString() });

			GymMembershipPlanEntity currentMembershipEntity = await _context.GymMembershipPlans.FirstOrDefaultAsync(mp => mp.Id == updatemembershipDTO.Id);
			GymMembershipPlanEntity updatedMembershipEntity = updatemembershipDTO.ToUpdatedEntity(currentMembershipEntity);
			await UpdateAsync(updatedMembershipEntity);
			return updatedMembershipEntity.ToDTO();
		}
		
	}

    public async Task<bool> DeleteMembershipAsync(int id, int branchId)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMembershipPlanService), nameof(DeleteMembershipAsync), DateTime.Now.ToString() });

			GymMembershipPlanEntity MembershipEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == branchId);
			await DeleteAsync(MembershipEntity);
			return true;
		}
		
    }
}

