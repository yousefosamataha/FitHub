using gms.data.Models.Base;

namespace gms.data.Models;

public class SystemSubscriptionEntity : BaseEntity
{
    public int PlanId { get; set; }
    public decimal SubscriptionAmount { get; set; }
    public DateTime SubscriptionStartTime { get; set; }
    public DateTime SubscriptionEndTime { get; set; }
    public byte SubscriptionTypeId { get; set; }
    public byte SubscriptionStatusId { get; set; }
    public virtual PlanEntity Plan { get; set; }
    public virtual SubscriptionTypeEnumEntity SubscriptionType { get; set; }
    public virtual SubscriptionStatusEnumEntity SubscriptionStatus { get; set; }

    //public int GymId { get; set; }
    //public virtual Gym Gym { get; set; }
}
