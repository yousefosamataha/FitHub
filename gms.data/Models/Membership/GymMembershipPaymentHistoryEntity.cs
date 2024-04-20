using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Membership;
public class GymMembershipPaymentHistoryEntity : BaseEntity
{
    public int GymMemberMembershipId { get; set; }
    public decimal PaidAmount { get; set; }
    public PaymentMethodEnum PaymentMethodId { get; set; }
    public string? TransactionId { get; set; }
    public int CreatedById { get; set; }
    public DateTime PaidDate { get; set; }

    // Navigation properties
    public virtual GymMemberMembershipEntity GymMemberMembership { get; set; }
    // public virtual GymUserEntity GymStaffUser { get; set; }
}
