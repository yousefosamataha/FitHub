using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Membership;
public class GymMemberMembershipEntity : BaseEntity
{
    public int MembershipId { get; set; }
    public int MemberId { get; set; }
    public StatusEnum MemberShipStatusId { get; set; }
    public StatusEnum PaymentStatusId { get; set; }
    public DateTime JoiningDate { get; set; }
    public DateTime ExpiringDate { get; set; }
    public virtual ICollection<GymMembershipPaymentHistoryEntity> MembershipPaymentHistories { get; set; }

    // TODO: Add Relation Entities
    //public int CreatedById { get; set; }
    //public DateTime CreatedDate { get; set; }
    //public MembershipPlan MembershipPlan { get; set; }
    //public GymMember Member { get; set; }
}
