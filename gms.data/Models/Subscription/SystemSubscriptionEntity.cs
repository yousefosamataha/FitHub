using gms.common.Enums;
using gms.data.Models.Base;
using gms.data.Models.Gym;

namespace gms.data.Models.Subscription;

public class SystemSubscriptionEntity : BaseEntity
{
    public PlansEnum PlanId { get; set; }
    public int GymId { get; set; }
    public SubscriptionTypeEnum SubscriptionTypeId { get; set; }
    public decimal SubscriptionAmount { get; set; }
    public DateTime SubscriptionStartTime { get; set; }
    public DateTime SubscriptionEndTime { get; set; }
    public StatusEnum SubscriptionStatusId { get; set; }

    // Navigation properties
    public virtual GymEntity Gym { get; set; }
    public virtual ICollection<SubscriptionPaymentEntity> SubscriptionPayments { get; set; }
}
