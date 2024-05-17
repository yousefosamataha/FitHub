using gms.common.Models.GymCat.GymMemberGroup;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymMemberGroupMapper
{
    public static GymMemberGroupEntity ToEntity(this CreateGymMemberGroupDTO source)
    {
        return new GymMemberGroupEntity()
        {
            GymMemberUserId = source.GymMemberUserId,
            GymGroupId = source.GymGroupId
        };
    }

    public static GymMemberGroupDTO ToDTO(this GymMemberGroupEntity source)
    {
        return new GymMemberGroupDTO()
        {
            Id = source.Id,
            GymMemberUserId = source.GymMemberUserId,
            GymGroupId = source.GymGroupId
        };
    }
}
