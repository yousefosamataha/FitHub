using gms.data.Models.Base;
using gms.data.Models.Identity;
using gms.data.Models.Member;
using gms.data.Models.Membership;
using gms.data.Models.Staff;

namespace gms.data.Models.Class;

public class ClassScheduleEntity : GymBaseEntity
{
    public required string ClassName { get; set; }
    public int ClassLocationId { get; set; }
    public decimal ClassFees { get; set; }
    public TimeOnly StartTime { get; set; } 
    public TimeOnly EndTime { get; set; }
    public int CreatedById { get; set; }

    // Navigation properties
    public virtual ClassLocationEntity ClassLocation { get; set; }
    public virtual ICollection<ClassScheduleDayEntity> ClassScheduleDays { get; set; }
    public virtual ICollection<StaffClassEntity> StaffClasses { get; set; }
    public virtual ICollection<GymMembershipPlanClassEntity> MembershipPlanClasses { get; set; }
    public virtual GymUserEntity GymStaffUser { get; set; }
    public virtual ICollection<MemberClassEntity> MemberClasses { get; set; }
}
