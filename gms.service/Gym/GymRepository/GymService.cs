using gms.common.Models.GymCat.Gym;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymRepository;
public class GymService : BaseRepository<GymEntity>, IGymService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymService> _logger;
	public GymService
	(
		ApplicationDbContext context, 
		IHttpContextAccessor httpContextAccessor, 
		ILogger<GymService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}


	public async Task<GymDTO> CreateGymAsync(CreateGymDTO newGym)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymService), nameof(CreateGymAsync), DateTime.Now.ToString() });

			GymEntity newGymEntity = newGym.ToEntity();
			await AddAsync(newGymEntity);
			return newGymEntity.ToDTO();
		}
		
    }
}
