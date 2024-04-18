using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymSpecializationEntity : GymBaseEntity
{
    public required string Name { get; set; }
    public virtual ICollection<GymStaffSpecializationEntity> GymStaffSpecializations { get; set; }
}
