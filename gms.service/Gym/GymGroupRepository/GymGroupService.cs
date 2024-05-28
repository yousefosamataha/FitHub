using gms.common.Models.GymCat.GymGroup;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.service.Gym.GymBranchRepository;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymGroupRepository;

public class GymGroupService : BaseRepository<GymGroupEntity>, IGymGroupService
{
    private readonly ApplicationDbContext _context;
    private readonly IGymBranchService _gymBranchService;
	private readonly ILogger<GymGroupService> _logger;
	public GymGroupService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor,
		IGymBranchService gymBranchService, 
		ILogger<GymGroupService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_gymBranchService = gymBranchService;
		_logger = logger;
	}

	#region Gym Group Service
	public async Task<GymGroupDTO> AddGymGroupAsync(CreateGymGroupDTO entity)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymGroupService), nameof(AddGymGroupAsync), DateTime.Now.ToString() });

			GymGroupEntity newGroupEntity = entity.ToEntity();
			await AddAsync(newGroupEntity);
			return newGroupEntity.ToDTO();
		}
		
	}

	public async Task<List<GymGroupDTO>> GetGymGroupsListAsync()
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymGroupService), nameof(GetGymGroupsListAsync), DateTime.Now.ToString() });

			GymBranchEntity branchData = await _gymBranchService.FindAsync(gb => gb.Id == GetBranchId(), ["Country"]);
			List<GymGroupEntity> listOfGroups = await FindAllAsync(gg => gg.BranchId == GetBranchId());
			return listOfGroups.Select(gg => gg.ToDTO(branchData.Country.TimezoneOffset)).ToList();
		}
		
	}

    public async Task<GymGroupDTO> GetGroupByIdAsync(int id)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymGroupService), nameof(GetGroupByIdAsync), DateTime.Now.ToString() });

			GymGroupEntity? groupEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == GetBranchId());
			return groupEntity.ToDTO();
		}
	
    }

	public async Task<GymGroupDTO> UpdateGymGroupAsync(UpdateGroupDTO updateGroupDTO)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymGroupService), nameof(UpdateGymGroupAsync), DateTime.Now.ToString() });

			GymGroupEntity currentGroupEntity = await _context.GymGroups.FirstOrDefaultAsync(mp => mp.Id == updateGroupDTO.Id && mp.BranchId == GetBranchId());
			GymGroupEntity updatedGroupEntity = updateGroupDTO.ToUpdatedEntity(currentGroupEntity);
			await UpdateAsync(updatedGroupEntity);
			return updatedGroupEntity.ToDTO();
		}
		
	}

	public async Task<bool> DeleteGroupAsync(int id)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymGroupService), nameof(DeleteGroupAsync), DateTime.Now.ToString() });

			GymGroupEntity? GroupEntity = await FindAsync(mp => mp.Id == id && mp.BranchId == GetBranchId());
			await DeleteAsync(GroupEntity);
			return true;
		}
		
    }
    #endregion Gym Group Service
}