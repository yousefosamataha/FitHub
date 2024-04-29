using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Shared;

public class CountryEntity : BaseEntity
{
    public required string Name { get; set; }
    public required string Currency { get; set; }
    public required string CurrencyCode { get; set; }
    public required string CurrencySymbol { get; set; }
    public required string TimeZone { get; set; }
    public required string TimezoneOffset { get; set; }
    public required string Language { get; set; }
    public required string CallingCode { get; set; }
    public required byte[] Flag { get; set; }
    public required ImageTypeEnum? FlagTypeId { get; set; }
}
