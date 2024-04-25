namespace gms.common.Models.GymCat.Gym;

public record struct GymDTO
{
    public int GymId { get; init; }
    public string Name { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? ModifiedAt { get; init; }
    public int? CreatedById { get; init; }
    public bool IsDeleted { get; init; }
    public int GeneralSettingId { get; init; }

}
