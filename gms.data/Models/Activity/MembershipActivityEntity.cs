using gms.data.Models.Base;
using gms.data.Models.Membership;

namespace gms.data.Models.Activity;
public class MembershipActivityEntity : BaseEntity
{
    public int ActivityId { get; set; }
    public int MembershipPlanId { get; set; }

    // Navigation properties
    public virtual ActivityEntity Activity { get; set; }
    public GymMembershipPlanEntity MembershipPlan { get; set; }
}
