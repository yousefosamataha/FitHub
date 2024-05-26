using gms.data;
using gms.data.Models.Nutrition;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Nutrition.MealTimeRepository;
public class MealTimeService : BaseRepository<MealTimeEntity>, IMealTimeService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<MealTimeService> _logger;
	public MealTimeService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor,
		ILogger<MealTimeService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}
}