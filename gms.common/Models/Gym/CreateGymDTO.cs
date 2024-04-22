namespace gms.common.Models.Gym;
public record struct CreateGymDTO
{
    public string Name { get; init; }
    public int GeneralSettingId { get; init; }

    //public static implicit operator GymEntity(CreateGymDTO entity)
    //{
    //    return new GymDTO()
    //    {
    //        GymId = entity.Id,
    //        Name = entity.Name
    //    };
    //}
}
