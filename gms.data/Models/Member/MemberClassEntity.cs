using gms.data.Models.Base;
using gms.data.Models.Class;
using gms.data.Models.Identity;

namespace gms.data.Models.Member;

public class MemberClassEntity : BaseEntity
{
    public int GymMemberUserId { get; set; }
    public int ClassScheduleId { get; set; }

    // Navigation properties
    public virtual GymUserEntity GymMemberUser { get; set; }
    public virtual ClassScheduleEntity ClassSchedule { get; set; }
}
