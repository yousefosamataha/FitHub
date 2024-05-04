using gms.common.Models.Shared.Country;
using gms.data.Models.Shared;
using gms.services.Base;

namespace gms.service.Shared.CountryRepository;

public interface ICountryService : IBaseRepository<CountryEntity>
{
    Task<List<CountryDTO>> GetCountriesListAsync();
}
