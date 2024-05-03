using gms.common.Enums;
using gms.common.Models.GymCat.GymGroup;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymGroupMapper
{
    public static GymGroupEntity ToEntity(this CreateGymGroupDTO source)
    {
        return new GymGroupEntity()
        {
            BranchId = source.BranchId,
            Name = source.Name,
            Image = Convert.FromBase64String(source.Image),
            ImageTypeId = (ImageTypeEnum)Enum.Parse(typeof(ImageTypeEnum), source.ImageType)
        };
    }

    public static GymGroupDTO ToDTO(this GymGroupEntity entity)
    {
        return new GymGroupDTO()
        {
            Id = entity.Id,
            BranchId = entity.BranchId,
            Name = entity.Name,
            Image = $"data:image/{entity.ImageTypeId?.ToString()};base64,{Convert.ToBase64String(entity.Image)}",
        };
    }
}
