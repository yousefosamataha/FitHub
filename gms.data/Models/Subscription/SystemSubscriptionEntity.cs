using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Subscription;

public class SystemSubscriptionEntity : BaseEntity
{
    public decimal SubscriptionAmount { get; set; }
    public DateTime SubscriptionStartTime { get; set; }
    public DateTime SubscriptionEndTime { get; set; }
    public PlansEnum PlanId { get; set; }
    public SubscriptionTypeEnum SubscriptionTypeId { get; set; }
    public SubscriptionStatusEnum SubscriptionStatusId { get; set; }

    //TODO: ADD GYM ENTITY Navegation
    //public int GymId { get; set; }
    //public virtual Gym Gym { get; set; }
}
