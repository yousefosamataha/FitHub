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
}
