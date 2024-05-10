using gms.common.Enums;

namespace gms.common.Models.MembershipCat;

public record MembershipDTO
{
	public int Id { get; init; }
	public int BranchId { get; init; }
	public required string MembershipName { get; init; }
	public int MembershipDuration { get; init; }
	public MembershipLengthTypeEnum MembershipDurationTypeId { get; init; }
	public decimal MembershipAmount { get; init; }
	public StatusEnum MembershipStatusId { get; init; }
	public decimal SignupFee { get; init; }
	public string? MembershipDescription { get; init; }
	public bool ClassIsLimit { get; init; }
	public int? ClassLimitDays { get; init; }
	public MembershipClassLimitationEnum? ClassLimitationId { get; init; }
	public int? CreatedById { get; init; }
	public DateTime? CreatedAt { get; init; }
}
