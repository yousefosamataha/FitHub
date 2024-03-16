using gms.data.Models.Base;

namespace gms.data.Models.Shared;

public class CountryEntity : BaseEntity
{
	public string Name { get; set; }
	public string Currency { get; set; }
	public string TimeZone { get; set; }
	public string Language { get; set; }
}
