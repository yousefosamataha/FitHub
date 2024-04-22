using gms.data;
using gms.data.Models.Activity;
using gms.services.Base;

namespace gms.service.Activity.ActivityVideoRepository;
public class ActivityVideoService : BaseRepository<ActivityVideoEntity>, IActivityVideoService
{
	private readonly ApplicationDbContext _context;
	public ActivityVideoService(ApplicationDbContext context) : base(context)
	{
		_context = context;
	}
}
