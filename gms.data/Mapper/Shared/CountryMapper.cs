using gms.common.Models.Shared.Country;
using gms.data.Models.Shared;

namespace gms.data.Mapper.Shared;

public static class CountryMapper
{
    public static CountryDTO ToDTO(this CountryEntity source)
    {
        return new CountryDTO()
        {
            Id = source.Id, 
            Name = source.Name, 
            Currency = source.Currency,
            CurrencyCode = source.CurrencyCode,
            CurrencySymbol = source.CurrencySymbol,
            TimeZone = source.TimeZone,
            TimezoneOffset = source.TimezoneOffset,
            Language = source.Language,
            CallingCode = source.CallingCode,
            Flag = Convert.ToBase64String(source.Flag),
            FlagType = source.FlagType,
        };
    }
}
