using gms.common.Enums;

namespace gms.common.Models.SubscriptionCat.SystemSubscription;

public record CreateSystemSubscriptionDTO
{
    public PlansEnum PlanId { get; init; }
    public int GymId { get; init; }
    public SubscriptionTypeEnum SubscriptionTypeId { get; init; }
    public decimal SubscriptionAmount { get; init; }
    public DateTime SubscriptionStartTime { get; init; }
    public DateTime SubscriptionEndTime { get; init; }
    public StatusEnum SubscriptionStatusId { get; init; }
    public int CreatedById { get; init; }
}
