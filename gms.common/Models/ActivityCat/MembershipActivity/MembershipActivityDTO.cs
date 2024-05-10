namespace gms.common.Models.ActivityCat.MembershipActivity;

public record MembershipActivityDTO
{
    public int Id { get; set; }
    public int ActivityId { get; set; }
    public int MembershipPlanId { get; set; }
}
