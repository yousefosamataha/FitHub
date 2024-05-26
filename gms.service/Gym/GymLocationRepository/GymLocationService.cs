using gms.common.Models.GymCat.GymLocation;
using gms.data;
using gms.data.Mapper.Gym;
using gms.data.Models.Gym;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Gym.GymLocationRepository;

public class GymLocationService : BaseRepository<GymLocationEntity>, IGymLocationService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<GymLocationService> _logger;
	public GymLocationService
    (
        ApplicationDbContext context, 
        IHttpContextAccessor httpContextAccessor, 
        ILogger<GymLocationService> logger
    ) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<bool> CreateNewGymLocationAsync(CreateGymLocationDTO createGymLocationModal)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymLocationService), nameof(CreateNewGymLocationAsync), DateTime.Now.ToString() });

			GymLocationEntity gymLocationEntity = createGymLocationModal.ToEntity();
			gymLocationEntity.BranchId = GetBranchId();
			await AddAsync(gymLocationEntity);
			return true;
		}
		
    }

    public async Task<List<GymLocationDTO>> GetGymLocationsListAsync()
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymLocationService), nameof(GetGymLocationsListAsync), DateTime.Now.ToString() });

			List<GymLocationEntity> listOfGymLocations = await FindAllAsync(gl => gl.BranchId == GetBranchId());
			return listOfGymLocations.Select(gl => gl.ToDTO()).ToList();
		}
		
    }

    public async Task<bool> DeleteGymLocationAsync(int gymLocationId)
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(GymLocationService), nameof(DeleteGymLocationAsync), DateTime.Now.ToString() });

			GymLocationEntity gymLocationEntity = await FindAsync(gl => gl.Id == gymLocationId && gl.BranchId == GetBranchId());
			await DeleteAsync(gymLocationEntity);
			return true;
		}
		
    }
}
