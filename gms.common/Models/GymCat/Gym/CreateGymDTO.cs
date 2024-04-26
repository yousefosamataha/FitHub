namespace gms.common.Models.GymCat.Gym;
public record struct CreateGymDTO
{
    public string Name { get; init; }
    public int GeneralSettingId { get; init; }
}
