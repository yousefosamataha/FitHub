using gms.common.Models.Shared.Country;
using gms.data;
using gms.data.Mapper.Shared;
using gms.data.Models.Shared;
using gms.services.Base;
using Microsoft.AspNetCore.Http;

namespace gms.service.Shared.CountryRepository;

public class CountryService : BaseRepository<CountryEntity>, ICountryService
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CountryService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<List<CountryDTO>> GetCountriesListAsync()
    {
        List<CountryEntity> CountriesList = await base.GetAllAsync();
        List<CountryDTO> CountriesListDTO = CountriesList.Select(c => c.ToDTO()).ToList();
        return CountriesListDTO;
    }
}
