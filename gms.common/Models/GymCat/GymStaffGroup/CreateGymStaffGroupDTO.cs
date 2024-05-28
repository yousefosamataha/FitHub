namespace gms.common.Models.GymCat.GymStaffGroup;

public record CreateGymStaffGroupDTO
{
	public int GymStaffUserId { get; init; }
	public int GymGroupId { get; init; }
}
