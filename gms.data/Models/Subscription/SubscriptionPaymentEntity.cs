using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Subscription;
public class SubscriptionPaymentEntity : BaseEntity
{
    public int SubscriptionId { get; set; }
    public PaymentMethodEnum PaymentMethodId { get; set; }
    public decimal PaidAmount { get; set; }
    public string TransactionId { get; set; }
    public DateTime PaidDate { get; set; }

    // Navigation properties
    public virtual SystemSubscriptionEntity Subscription { get; set; }
}