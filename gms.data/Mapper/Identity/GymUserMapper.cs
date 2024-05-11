using gms.common.Enums;
using gms.common.Models.Identity.User;
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
			GenderId = (GenderEnum)source.GenderId,
			BirthDate = (DateOnly)source.BirthDate,
			Address = source.Address,
			City = source.City,
			State = source.State,
			StatusId = (StatusEnum)source.StatusId,
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
			Email = entity.Email,
			UserName = entity.UserName,
			GenderId = entity.GenderId,
			BirthDate = entity.BirthDate,
			Address = entity.Address,
			City = entity.City,
			State = entity.State,
			StatusId = entity.StatusId,
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
