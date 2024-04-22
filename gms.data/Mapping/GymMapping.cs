using gms.common.Models.Gym;
using gms.data.Models.Gym;

namespace gms.data.Mapping;

public static class GymMapping
{
    public static GymEntity ToGymEntity(this CreateGymDTO source)
    {
        return new GymEntity()
        {
            Name = source.Name,
        };
    }
}
