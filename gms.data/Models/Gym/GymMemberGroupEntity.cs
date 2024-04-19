using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;
public class GymMemberGroupEntity : BaseEntity
{
    public int GymMemberUserId { get; set; }
    public int GymGroupId { get; set; }

    // Navigation properties
    public virtual GymUserEntity GymMemberUser { get; set; }
    public virtual GymGroupEntity GymGroup { get; set; }
}
