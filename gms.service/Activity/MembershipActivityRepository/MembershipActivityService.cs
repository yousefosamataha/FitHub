using gms.common.Models.ActivityCat.MembershipActivity;
using gms.data;
using gms.data.Mapper.Activity;
using gms.data.Models.Activity;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Activity.MembershipActivityRepository;
public class MembershipActivityService : BaseRepository<MembershipActivityEntity>, IMembershipActivityService
{
	private readonly ApplicationDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public MembershipActivityService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

    public async Task<bool> CreateNewMembershipActivityAsync(List<CreateMembershipActivityDTO> membershipActivitiesListDto)
	{
		List<MembershipActivityEntity> createMembershipActivity = membershipActivitiesListDto.Select(ma => ma.ToEntity()).ToList();
		await AddRangeAsync(createMembershipActivity);
		return true;
	}

    public async Task<List<MembershipActivityDTO>> GetActivityMembershipsListAsync(int activityId)
    {
        List<MembershipActivityEntity> membershipActivitiesList = await FindAllAsync(ma => ma.ActivityId == activityId);
		return membershipActivitiesList.Select(ma => ma.ToDTO()).ToList();
    }

    public async Task<bool> UpdateMembershipActivityAsync(List<CreateMembershipActivityDTO> updateMembershipActivitiesListDto, int activityId)
    {
        List<MembershipActivityEntity> curentMembershipActivitiesList = await FindAllAsync(ma => ma.ActivityId == activityId);
		_context.MembershipActivities.RemoveRange(curentMembershipActivitiesList);
        await _context.SaveChangesAsync();
        List<MembershipActivityEntity> newMembershipActivitiesList = updateMembershipActivitiesListDto.Select(ma => ma.ToEntity()).ToList();
		await AddRangeAsync(newMembershipActivitiesList);
        return true;
    }
}
