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
            Image = source.Image is not null ? Convert.FromBase64String(source.Image) : new byte[0],
            ImageTypeId = source.Image is not null ? (ImageTypeEnum)Enum.Parse(typeof(ImageTypeEnum), source.ImageType) : null
        };
    }

    public static GymGroupDTO ToDTO(this GymGroupEntity entity, string? TimezoneOffset = "0")
    {
        return new GymGroupDTO()
        {
            Id = entity.Id,
            BranchId = entity.BranchId,
            Name = entity.Name,
            Image = entity.Image?.Length != 0 ? $"data:image/{entity.ImageTypeId?.ToString()};base64,{Convert.ToBase64String(entity.Image)}" : null,
            CreatedAt = entity.CreatedAt.AddHours(double.Parse(TimezoneOffset, System.Globalization.CultureInfo.InvariantCulture))
        };
    }

    public static UpdateGroupDTO ToUpdateDTO(this GymGroupDTO source)
    {
        return new UpdateGroupDTO()
        {
            Id = source.Id,
            BranchId = source.BranchId,
            Name = source.Name,
            Image = source.Image,
        };
    }

	public static GymGroupEntity ToUpdatedEntity(this UpdateGroupDTO source, GymGroupEntity entity)
	{
		entity.Name = !string.IsNullOrWhiteSpace(source.Name) && !string.Equals(source.Name, entity.Name, StringComparison.OrdinalIgnoreCase) ? source.Name : entity.Name;
        entity.Image = source.Image is not null ? Convert.FromBase64String(source.Image?.Split(";base64,")[1]) : new byte[0];
        entity.ImageTypeId = source.Image is not null ? (ImageTypeEnum)Enum.Parse(typeof(ImageTypeEnum), source.Image?.Split(";base64,")[0].Split("data:image/")[1]) : null;

		return entity;
	}
}
