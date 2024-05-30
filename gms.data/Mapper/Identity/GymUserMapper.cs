using gms.common.Enums;
using gms.common.Models.Identity.User;
using gms.common.Models.IdentityCat.User;
using gms.data.Mapper.Gym;
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
            GymMemberMembership = entity.GymMemberMemberships?.OrderByDescending(mmp => mmp.ExpiringDate).FirstOrDefault()?.ToDTO(),
            GymMemberGroups = entity.GymMemberGroups?.Select(gmg => gmg.ToDTO()).ToList(),
			GymStaffGroups = entity.GymStaffGroups?.Select(gsg => gsg.ToDTO()).ToList(),
            GymStaffSpecializations = entity.GymStaffSpecializations?.Select(gss => gss.ToDTO()).ToList()
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

    public static GymUserEntity ToUpdatedEntity(this UpdateGymUserDTO source, GymUserEntity entity)
    {
        entity.Image = source.Image is not null ? Convert.FromBase64String(source.Image?.Split(";base64,")[1]) : new byte[0];
        entity.ImageTypeId = source.Image is not null ? (ImageTypeEnum)Enum.Parse(typeof(ImageTypeEnum), source.Image?.Split(";base64,")[0].Split("data:image/")[1]) : null;
        entity.FirstName = !string.IsNullOrWhiteSpace(source.FirstName) && !string.Equals(source.FirstName, entity.FirstName, StringComparison.OrdinalIgnoreCase) ? source.FirstName : entity.FirstName;
        entity.LastName = !string.IsNullOrWhiteSpace(source.LastName) && !string.Equals(source.LastName, entity.LastName, StringComparison.OrdinalIgnoreCase) ? source.LastName : entity.LastName;
        entity.GenderId = source.GenderId;
        entity.BirthDate = source.BirthDate;
        entity.Address = !string.IsNullOrWhiteSpace(source.Address) && !string.Equals(source.Address, entity.Address, StringComparison.OrdinalIgnoreCase) ? source.Address : entity.Address;
        entity.City = !string.IsNullOrWhiteSpace(source.City) && !string.Equals(source.City, entity.City, StringComparison.OrdinalIgnoreCase) ? source.City : entity.City;
        entity.State = !string.IsNullOrWhiteSpace(source.State) && !string.Equals(source.State, entity.State, StringComparison.OrdinalIgnoreCase) ? source.State : entity.State;
        entity.PhoneNumber = !string.IsNullOrWhiteSpace(source.PhoneNumber) && !string.Equals(source.PhoneNumber, entity.PhoneNumber, StringComparison.OrdinalIgnoreCase) ? source.PhoneNumber : entity.PhoneNumber;
        entity.Email = !string.IsNullOrWhiteSpace(source.Email) && !string.Equals(source.Email, entity.Email, StringComparison.OrdinalIgnoreCase) ? source.Email : entity.Email;
        entity.StatusId = source.StatusId;

        return entity;
    }
}
