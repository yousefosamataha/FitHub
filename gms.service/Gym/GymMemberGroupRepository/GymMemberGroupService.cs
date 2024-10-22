﻿using gms.common.Models.GymCat.GymMemberGroup;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymMemberGroupRepository;
public class GymMemberGroupService : BaseRepository<GymMemberGroupEntity>, IGymMemberGroupService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymMemberGroupService> _logger;
	public GymMemberGroupService
    (
        ApplicationDbContext context, 
        IHttpContextAccessor httpContextAccessor, 
        ILogger<GymMemberGroupService> logger
    ) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<bool> CreateNewGymMemberGroupAsync(List<CreateGymMemberGroupDTO> gymMemberGroupsListDto)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberGroupService), nameof(CreateNewGymMemberGroupAsync), DateTime.Now.ToString() });

			List<GymMemberGroupEntity> createGymMemberGroupsList = gymMemberGroupsListDto.Select(mg => mg.ToEntity()).ToList();
			await AddRangeAsync(createGymMemberGroupsList);
			return true;
		}
		
    }

    public async Task<List<GymMemberGroupDTO>> GetGymMemberGroupsListAsync(int memberId)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberGroupService), nameof(GetGymMemberGroupsListAsync), DateTime.Now.ToString() });

			List<GymMemberGroupEntity> gymMemberGroupsList = await FindAllAsync(mg => mg.GymMemberUserId == memberId);
			return gymMemberGroupsList.Select(mg => mg.ToDTO()).ToList();
		}
		
    }

    public async Task<bool> UpdateGymMemberGroupAsync(List<CreateGymMemberGroupDTO> updateGymMemberGroupsListDto, int memberId)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymMemberGroupService), nameof(UpdateGymMemberGroupAsync), DateTime.Now.ToString() });

			List<GymMemberGroupEntity> currentGymMemberGroupsList = _context.GymMemberGroups.Where(mg => mg.GymMemberUserId == memberId).ToList();
			_context.GymMemberGroups.RemoveRange(currentGymMemberGroupsList);
			await _context.SaveChangesAsync();
			List<GymMemberGroupEntity> newGymMemberGroupsList = updateGymMemberGroupsListDto.Select(mg => mg.ToEntity()).ToList();
			await AddRangeAsync(newGymMemberGroupsList);
			return true;
		}
		
    }
}
