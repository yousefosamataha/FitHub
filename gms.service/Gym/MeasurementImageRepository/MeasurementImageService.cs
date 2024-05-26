using gms.data;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.MeasurementImageRepository;
public class MeasurementImageService : BaseRepository<MeasurementImageEntity>, IMeasurementImageService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<MeasurementImageService> _logger;
	public MeasurementImageService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		ILogger<MeasurementImageService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

}
