using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;
public class GymStaffSpecializationEntity : BaseEntity
{
    public int GymSpecializationId { get; set; }
    public virtual GymSpecializationEntity GymSpecialization { get; set; }
    public int GymStaffId { get; set; }
    public virtual GymUserEntity GymStaff { get; set; }
}
