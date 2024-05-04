using gms.common.Models.GymCat.Gym;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymMapper
{
    public static GymEntity ToEntity(this CreateGymDTO source)
    {
        return new GymEntity()
        {
            Name = source.Name,
        };
    }

    public static GymDTO ToDTO(this GymEntity source)
    {
        return new GymDTO()
        {
            Id = source.Id,
            Name = source.Name,
            IsDeleted = source.IsDeleted,
        };
    }
}
