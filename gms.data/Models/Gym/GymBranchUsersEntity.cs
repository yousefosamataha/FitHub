using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;

public class GymBranchUsersEntity : BaseEntity
{
    public int GymUserId { get; set; }
    public int GymBranchId { get; set; }
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual GymUserEntity GymUser { get; set; }
}
