using gms.common.Models.Shared.Country;
using gms.data;
using gms.data.Mapper.Shared;
using gms.data.Models.Shared;
using gms.services.Base;

namespace gms.service.Shared.CountryRepository;

public class CountryService : BaseRepository<CountryEntity>, ICountryService
{
    private readonly ApplicationDbContext _context;

    public CountryService(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<List<CountryDTO>> GetCountriesListAsync()
    {
        List<CountryEntity> CountriesList = await base.GetAllAsync();
        List<CountryDTO> CountriesListDTO = CountriesList.Select(c => c.ToDTO()).ToList();
        return CountriesListDTO;
    }
}
