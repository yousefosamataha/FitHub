using gms.common.Enums;
using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Membership;
public class GymMemberMembershipEntity : BaseEntity
{
    public int GymMembershipPlanId { get; set; }
    public int MemberId { get; set; }
    public StatusEnum MemberShipStatusId { get; set; }
    public StatusEnum PaymentStatusId { get; set; }
    public DateTime JoiningDate { get; set; }
    public DateTime ExpiringDate { get; set; }

    // Navigation properties
    public virtual GymMembershipPlanEntity GymMembershipPlan { get; set; }
    public virtual GymUserEntity GymMemberUser { get; set; }
    public virtual ICollection<GymMembershipPaymentHistoryEntity> MembershipPaymentHistories { get; set; }
}
