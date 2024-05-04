using gms.data.Models.Gym;

namespace gms.data.Models.Base;

public abstract class GymBaseEntity : BaseEntity
{
    public int GymId { get; set; }
    public int? BranchId { get; set; }

    // Navigation properties
    public virtual GymEntity Gym { get; set; }
    public virtual GymBranchEntity GymBranch { get; set; }
}
