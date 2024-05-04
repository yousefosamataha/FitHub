namespace gms.common.Models.Shared.Country;

public record struct CountryDTO
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public required string Currency { get; init; }
    public required string CurrencyCode { get; init; }
    public required string CurrencySymbol { get; init; }
    public required string TimeZone { get; init; }
    public required string TimezoneOffset { get; init; }
    public required string Language { get; init; }
    public required string CallingCode { get; init; }
    public required string Flag { get; init; }
}
