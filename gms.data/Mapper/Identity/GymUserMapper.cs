using gms.common.Enums;
using gms.common.Models.Identity;
using gms.common.Models.IdentityCat;
using gms.data.Models.Identity;

namespace gms.data.Mapper.Identity;
public static class GymUserMapper
{
	public static GymUserEntity ToEntity(this CreateGymUserDTO source)
	{
		return new GymUserEntity()
		{
			BranchId = (int)source.BranchId,
			Image = Convert.FromBase64String(source.Image),
            ImageTypeId = (ImageTypeEnum)Enum.Parse(typeof(ImageTypeEnum), source.ImageType),
            FirstName = source.FirstName,
			LastName = source.LastName,
			GenderId = (common.Enums.GenderEnum)source.GenderId,
            BirthDate = (DateOnly)source.BirthDate,
            Address = source.Address,
            City = source.City,
			State = source.State,
			StatusId = (common.Enums.StatusEnum)source.StatusId,
			GymUserTypeId = source.GymUserTypeId
		};
	}

	public static GymUserDTO ToDTO(this GymUserEntity entity)
    {
        return new GymUserDTO()
        {
			Id = entity.Id,
			BranchId = entity.BranchId,
			Image = $"data:image/{entity.ImageTypeId?.ToString()};base64,{Convert.ToBase64String(entity.Image)}",
			FirstName = entity.FirstName,
			LastName = entity.LastName,
			GenderId = (common.Enums.GenderEnum)entity.GenderId,
			BirthDate = (DateOnly)entity.BirthDate,
			Address = entity.Address,
			City = entity.City,
			State = entity.State,
			StatusId = (common.Enums.StatusEnum)entity.StatusId,
			GymUserTypeId = entity.GymUserTypeId
		};
    }

    public static GymUserClaimsDto ToClaimsDTO(this GymUserEntity entity)
    {
        return new GymUserClaimsDto()
        {
            UserId = entity.Id,
            GymId = entity.GymBranch.GymId,
            BranchId = entity.BranchId,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
			Email = entity.Email,
            GenderId = entity.GenderId,
            GymUserTypeId = entity.GymUserTypeId,
            UserStatusId = entity.StatusId,
        };
    }
}
