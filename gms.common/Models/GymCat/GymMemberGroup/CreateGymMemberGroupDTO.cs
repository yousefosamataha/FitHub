namespace gms.common.Models.GymCat.GymMemberGroup;

public record CreateGymMemberGroupDTO
{
    public int GymMemberUserId { get; init; }
    public int GymGroupId { get; init; }
}
