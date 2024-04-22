using gms.data.Models.Base;
using gms.data.Models.Gym;
using gms.data.Models.Member;
using gms.data.Models.Membership;
using gms.data.Models.Staff;

namespace gms.data.Models.Class;

public class ClassScheduleEntity : BaseEntity
{
    public int BranchId { get; set; }
    public required string ClassName { get; set; }
    public int GymLocationId { get; set; }
    public decimal ClassFees { get; set; }
    public TimeOnly StartTime { get; set; } 
    public TimeOnly EndTime { get; set; }

    // Navigation properties
    public virtual GymBranchEntity GymBranch { get; set; }
    public virtual ICollection<GymMembershipPlanClassEntity> MembershipPlanClasses { get; set; }
    public virtual GymLocationEntity GymLocation { get; set; }
    public virtual ICollection<ClassScheduleDayEntity> ClassScheduleDays { get; set; }
    public virtual ICollection<StaffClassEntity> StaffClasses { get; set; }
    public virtual ICollection<MemberClassEntity> MemberClasses { get; set; }
}
