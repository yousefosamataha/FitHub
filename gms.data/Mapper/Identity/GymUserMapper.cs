using gms.common.Models.Identity;
using gms.data.Models.Identity;

namespace gms.data.Mapper.Identity;
public static class GymUserMapper
{
    public static GymUserDto ToDTO(this GymUserEntity entity)
    {
        return new GymUserDto()
        {
            UserId = entity.Id,
            BranchId = entity.BranchId,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            GenderId = entity.GenderId,
            Image = entity.Image,
            GymUserTypeId = entity.GymUserTypeId,
            State = entity.State,
            StatusId = entity.StatusId,
            GymId = entity.GymBranch.GymId
        };
    }
    public static GymUserClaimsDto ToClaimsDTO(this GymUserEntity entity)
    {
        return new GymUserClaimsDto()
        {
            UserId = entity.Id,
            GymId = entity.GymBranch.GymId,
            BranchId = entity.BranchId,
            Name = entity.FirstName + " " + entity.LastName,
            GenderId = entity.GenderId,
            GymUserTypeId = entity.GymUserTypeId,
            State = entity.State,
            StatusId = entity.StatusId
        };
    }
}
