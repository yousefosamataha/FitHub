using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymNotificationRepository;
public class GymNotificationService : BaseRepository<GymNotificationEntity>, IGymNotificationService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymNotificationService> _logger;
	public GymNotificationService
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor,
		ILogger<GymNotificationService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

}
