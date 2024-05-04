using gms.common.Enums;
using gms.data.Models.Base;
using gms.data.Models.Subscription;

namespace gms.data.Models.Gym;

public class GymEntity : BaseEntity
{
	public required string Name { get; set; }
    public byte[]? GymLogo { get; set; }
    public ImageTypeEnum? GymLogoTypeId { get; set; }

    // Navigation properties
    public virtual ICollection<SystemSubscriptionEntity> SystemSubscriptions { get; set; }

	public virtual ICollection<GymBranchEntity> GymBranches { get; set; }
}
