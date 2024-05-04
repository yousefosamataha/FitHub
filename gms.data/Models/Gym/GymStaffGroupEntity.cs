using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;
public class GymStaffGroupEntity : BaseEntity
{
    public int GymStaffUserId { get; set; }
    public int GymGroupId { get; set; }

    // Navigation properties
    public virtual GymUserEntity GymStaffUser { get; set; }
    public virtual GymGroupEntity GymGroup { get; set; }
}
