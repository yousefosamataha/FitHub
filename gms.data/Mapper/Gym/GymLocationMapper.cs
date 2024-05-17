using gms.common.Models.GymCat.GymLocation;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymLocationMapper
{
    public static GymLocationEntity ToEntity(this CreateGymLocationDTO source)
    {
        return new GymLocationEntity()
        {
            BranchId = source.BranchId,
            Name = source.Name,
        };
    }

    public static GymLocationDTO ToDTO(this GymLocationEntity source)
    {
        return new GymLocationDTO()
        {
            Id = source.Id,
            BranchId = source.BranchId,
            Name = source.Name
        };
    }
}
