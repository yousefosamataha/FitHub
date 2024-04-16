using gms.data.Models.Base;
using gms.data.Models.Gym;

namespace gms.data.Models.Shared;

public class CountryEntity : BaseEntity
{
	public required string Name { get; set; }
	public required string Currency { get; set; }
	public required string TimeZone { get; set; }
	public required string Language { get; set; }
	public required byte[] Flag { get; set; }

    // Navigation properties
    public virtual ICollection<GymBranchEntity> GymBranches { get; set; }
}
