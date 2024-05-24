using gms.common.Enums;
using gms.common.Models.Identity.User;
using gms.data.Mapper.Membership;
using gms.data.Models.Identity;

namespace gms.data.Mapper.Identity;
public static class GymUserMapper
{
	public static GymUserEntity ToEntity(this CreateGymUserDTO source)
	{
		return new GymUserEntity()
		{
			BranchId = source.BranchId,
            Image = source.Image is not null ? Convert.FromBase64String(source.Image?.Split(";base64,")[1]) : new byte[0],
            ImageTypeId = source.Image is not null ? (ImageTypeEnum)Enum.Parse(typeof(ImageTypeEnum), source.Image?.Split(";base64,")[0].Split("data:image/")[1]) : null,
            FirstName = source.FirstName,
			LastName = source.LastName,
			GenderId = source.GenderId,
			BirthDate = source.BirthDate,
			Address = source.Address,
			City = source.City,
			State = source.State,
			PhoneNumber = source.PhoneNumber,
			Email = source.Email,
			UserName = source.Email,
			StatusId = source.StatusId
		};
	}

	public static GymUserDTO ToDTO(this GymUserEntity entity)
	{
		return new GymUserDTO()
		{
			Id = entity.Id,
			BranchId = entity.BranchId,
			Image = entity.Image?.Length != 0 ? $"data:image/{entity.ImageTypeId?.ToString()};base64,{Convert.ToBase64String(entity.Image)}" : null,
			FirstName = entity.FirstName,
			LastName = entity.LastName,
			GenderId = entity.GenderId,
			BirthDate = entity.BirthDate,
			Address = entity.Address,
			City = entity.City,
			State = entity.State,
            PhoneNumber = entity.PhoneNumber,
			Email = entity.Email,
			Password = entity.PasswordHash,
            StatusId = entity.StatusId,
            GymMemberMembership = entity.GymMemberMemberships?.OrderByDescending(mmp => mmp.JoiningDate).FirstOrDefault()?.ToDTO()
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
