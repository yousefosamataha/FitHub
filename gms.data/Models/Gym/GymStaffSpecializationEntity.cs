using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;
public class GymStaffSpecializationEntity : BaseEntity
{
    public string Name { get; set; }
    public virtual ICollection<GymUserEntity> GymUsers { get; set; }
}
