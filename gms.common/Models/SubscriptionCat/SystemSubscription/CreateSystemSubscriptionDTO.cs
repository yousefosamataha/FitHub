using gms.common.Enums;

namespace gms.common.Models.SubscriptionCat.SystemSubscription;

public record CreateSystemSubscriptionDTO
{
    public PlansEnum PlanId { get; set; }
    public int GymId { get; set; }
    public SubscriptionTypeEnum SubscriptionTypeId { get; set; }
    public decimal SubscriptionAmount { get; set; }
    public DateTime SubscriptionStartTime { get; set; }
    public DateTime SubscriptionEndTime { get; set; }
    public StatusEnum SubscriptionStatusId { get; set; }
    public int CreatedById { get; set; }
}
