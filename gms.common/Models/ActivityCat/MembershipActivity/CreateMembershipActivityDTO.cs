namespace gms.common.Models.ActivityCat.MembershipActivity;

public record CreateMembershipActivityDTO
{
	public int ActivityId { get; set; }
	public int MembershipPlanId { get; set; }
}
