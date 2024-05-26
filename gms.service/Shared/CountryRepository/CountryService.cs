using gms.common.Models.Shared.Country;
using gms.data;
using gms.data.Mapper.Shared;
using gms.data.Models.Shared;
using gms.services.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace gms.service.Shared.CountryRepository;

public class CountryService : BaseRepository<CountryEntity>, ICountryService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly ILogger<CountryService> _logger;
	public CountryService
	(
		ApplicationDbContext context,
		IHttpContextAccessor httpContextAccessor, 
		ILogger<CountryService> logger
	) : base(context, httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
		_logger = logger;
	}

	public async Task<List<CountryDTO>> GetCountriesListAsync()
    {
		using (_logger.BeginScope(GetScopesInformation()))
		{
			_logger.LogInformation("Request Received by Service: {Service}, ServiceMethod: {ServiceMethod}, DateTime: {DateTime}",
								  new object[] { nameof(CountryService), nameof(GetCountriesListAsync), DateTime.Now.ToString() });

			List<CountryEntity> CountriesList = await base.GetAllAsync();
			List<CountryDTO> CountriesListDTO = CountriesList.Select(c => c.ToDTO()).ToList();
			return CountriesListDTO;
		}
		
    }
}
