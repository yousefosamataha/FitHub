using gms.common.Models.Gym;
using gms.data.Models.Base;
using gms.data.Models.Subscription;

namespace gms.data.Models.Gym;

public class GymEntity : BaseEntity
{
    public required string Name { get; set; }
    public int GeneralSettingId { get; set; }

    // Navigation properties
    // public virtual GymGeneralSettingEntity GeneralSetting { get; set; }
    public virtual ICollection<SystemSubscriptionEntity> SystemSubscriptions { get; set; }
    public virtual ICollection<GymBranchEntity> GymBranches { get; set; }


    public static implicit operator GymDTO(GymEntity entity)
    {
        return new GymDTO()
        {
             GymId = entity.Id,
             Name = entity.Name
        };
    }
}
