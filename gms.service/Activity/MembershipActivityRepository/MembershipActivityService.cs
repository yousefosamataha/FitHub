using gms.common.Models.ActivityCat.MembershipActivity;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Activity.MembershipActivityRepository;
public class MembershipActivityService : BaseRepository<MembershipActivityEntity>, IMembershipActivityService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<MembershipActivityService> _logger;
	public MembershipActivityService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, ILogger<MembershipActivityService> logger) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<bool> CreateNewMembershipActivityAsync(List<CreateMembershipActivityDTO> membershipActivitiesListDto)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipActivityService), nameof(CreateNewMembershipActivityAsync), DateTime.Now.ToString() });

			List<MembershipActivityEntity> createMembershipActivity = membershipActivitiesListDto.Select(ma => ma.ToEntity()).ToList();
			await AddRangeAsync(createMembershipActivity);
			return true;
		}
		
	}

    public async Task<List<MembershipActivityDTO>> GetActivityMembershipsListAsync(int activityId)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipActivityService), nameof(GetActivityMembershipsListAsync), DateTime.Now.ToString() });

			List<MembershipActivityEntity> membershipActivitiesList = await FindAllAsync(ma => ma.ActivityId == activityId);
			return membershipActivitiesList.Select(ma => ma.ToDTO()).ToList();
		}
		
    }

    public async Task<bool> UpdateMembershipActivityAsync(List<CreateMembershipActivityDTO> updateMembershipActivitiesListDto, int activityId)
	{
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(MembershipActivityService), nameof(UpdateMembershipActivityAsync), DateTime.Now.ToString() });

			List<MembershipActivityEntity> currentMembershipActivitiesList = await FindAllAsync(ma => ma.ActivityId == activityId);
			_context.MembershipActivities.RemoveRange(currentMembershipActivitiesList);
			await _context.SaveChangesAsync();
			List<MembershipActivityEntity> newMembershipActivitiesList = updateMembershipActivitiesListDto.Select(ma => ma.ToEntity()).ToList();
			await AddRangeAsync(newMembershipActivitiesList);
			return true;
		}
		
    }
}
