namespace gms.common.Models.GymCat.GymMemberGroup;

public record GymMemberGroupDTO
{
    public int Id { get; init; }
    public int GymMemberUserId { get; init; }
    public int GymGroupId { get; init; }
}
