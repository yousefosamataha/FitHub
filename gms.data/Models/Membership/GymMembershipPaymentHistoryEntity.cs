using gms.common.Enums;
using gms.data.Models.Base.Entities;

namespace gms.data.Models.Membership;
public class GymMembershipPaymentHistoryEntity : BaseEntity
{
    public int GymMemberMembershipId { get; set; }
    public decimal PaidAmount { get; set; }
    public PaymentMethodEnum PaymentMethodId { get; set; }
    public string TransactionId { get; set; }

    public virtual GymMemberMembershipEntity GymMemberMembership { get; set; }

    // TODO: Add Relation Entities
    //public int GymId { get; set; } // FK
    //public int CreatedById { get; set; }
}
