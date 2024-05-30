namespace gms.common.Models.GymCat.GymStaffGroup;

public record GymStaffGroupDTO
{
	public int Id { get; init; }
	public int GymStaffUserId { get; init; }
	public int GymGroupId { get; init; }
}
