using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Membership;
public class GymMembershipEntity : BaseEntity
{
    public int MembershipId { get; set; }
    public StatusEnum SubscriptionStatusId { get; set; }
    public StatusEnum PaymentStatusId { get; set; }
    public DateTime JoiningDate { get; set; }
    public DateTime ExpiringDate { get; set; }

    // TODO: Add Relation Entities
    //public int MemberId { get; set; }
    //public int CreatedById { get; set; }
    //public virtual GymMembershipPlanEntity MembershipPlan { get; set; }
}
