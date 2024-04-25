namespace gms.common.Models.Shared.Country;

public record struct CountryDTO
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Currency { get; set; }
    public required string CurrencyCode { get; set; }
    public required string CurrencySymbol { get; set; }
    public required string TimeZone { get; set; }
    public required string TimezoneOffset { get; set; }
    public required string Language { get; set; }
    public required string CallingCode { get; set; }
    public required string Flag { get; set; }
    public required string FlagType { get; set; }
}
