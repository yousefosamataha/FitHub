using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;
public class GymStaffSpecializationEntity : BaseEntity
{
    public int GymStaffId { get; set; }
    public int GymSpecializationId { get; set; }

    // Navigation properties
    public virtual GymUserEntity GymStaffUser { get; set; }
    public virtual GymSpecializationEntity GymSpecialization { get; set; }
}
