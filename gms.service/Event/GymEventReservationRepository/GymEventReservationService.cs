using gms.data;
using gms.data.Models.Event;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Event.GymEventReservationRepository;
public class GymEventReservationService : BaseRepository<GymEventReservationEntity>, IGymEventReservationService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymEventReservationService> _logger;
	public GymEventReservationService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		ILogger<GymEventReservationService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

}
