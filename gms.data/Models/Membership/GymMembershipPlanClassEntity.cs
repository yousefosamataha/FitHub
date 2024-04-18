using gms.data.Models.Base;
using gms.data.Models.Class;


namespace gms.data.Models.Membership;
public class GymMembershipPlanClassEntity : BaseEntity
{
    public int MembershipPlanId { get; set; }
    public int ClassScheduleId { get; set; }

    // Navigation properties
    public virtual GymMembershipPlanEntity MembershipPlan { get; set; }
    public virtual ClassScheduleEntity ClassSchedule { get; set; }
}
