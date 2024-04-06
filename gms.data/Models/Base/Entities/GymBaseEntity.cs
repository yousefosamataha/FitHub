using gms.data.Models.Gym;

namespace gms.data.Models.Base.Entities;
public abstract class GymBaseEntity : BaseEntity
{
    public int GymId { get; set; }

    public virtual GymEntity Gym { get; set; }

    public int? BranchId { get; set; }

    public virtual GymBranchEntity GymBranch { get; set; }
}
