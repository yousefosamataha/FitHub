using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Membership;
public class GymMembershipPaymentHistoryEntity : BaseEntity
{
    public decimal PaidAmount { get; set; }
    public PaymentMethodEnum PaymentMethodId { get; set; }
    public string TransactionId { get; set; }

    // TODO: Add Relation Entities
    //public GymMemberMembership GymMemberMembership { get; set; }
    //public int GymId { get; set; } // FK
    //public int CreatedById { get; set; }
}
