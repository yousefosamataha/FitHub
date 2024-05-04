using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymSpecializationEntity : BaseEntity
{
    public int BranchId { get; set; }
    public required string Name { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual ICollection<GymStaffSpecializationEntity> GymStaffSpecializations { get; set; }
}
