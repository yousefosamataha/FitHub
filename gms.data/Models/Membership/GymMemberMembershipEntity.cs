using gms.common.Enums;
using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Membership;
public class GymMemberMembershipEntity : GymBaseEntity
{
    public int GymMembershipPlanId { get; set; }
    public int MemberId { get; set; }
    public StatusEnum MemberShipStatusId { get; set; }
    public StatusEnum PaymentStatusId { get; set; }
    public DateTime JoiningDate { get; set; }
    public DateTime ExpiringDate { get; set; }
    // public int CreatedById { get; set; }

    // Navigation properties
    public virtual GymMembershipPlanEntity GymMembershipPlan { get; set; }
    public virtual GymUserEntity GymMemberUser { get; set; }
    // public virtual GymUserEntity GymStaffUser { get; set; }
    public virtual ICollection<GymMembershipPaymentHistoryEntity> MembershipPaymentHistories { get; set; }

    // TODO: Add Relation Entities
    //public int CreatedById { get; set; }
}
