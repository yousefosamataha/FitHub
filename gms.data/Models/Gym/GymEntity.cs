using gms.data.Models.Base;
using gms.data.Models.Subscription;

namespace gms.data.Models.Gym;

public class GymEntity : BaseEntity
{
    public required string Name { get; set; }

    public int GeneralSettingId { get; set; }

    // Navigation properties
    public virtual GymGeneralSettingEntity GeneralSetting { get; set; }

    public virtual ICollection<SystemSubscriptionEntity> SystemSubscriptions { get; set; }

    public virtual ICollection<GymBranchEntity> GymBranches { get; set; }

    public virtual ICollection<GymGroupEntity> GymGroups { get; set; }

    // TODO: Add Relation Entities
    // public virtual ICollection<GymUserEntity> GymUsers { get; set; }
}
