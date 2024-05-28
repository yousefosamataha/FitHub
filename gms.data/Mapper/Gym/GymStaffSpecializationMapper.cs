using gms.common.Models.GymCat.GymStaffSpecialization;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymStaffSpecializationMapper
{
	public static GymStaffSpecializationEntity ToEntity(this CreateGymStaffSpecializationDTO source)
	{
		return new GymStaffSpecializationEntity()
		{
			GymStaffId = source.GymStaffId,
			GymSpecializationId = source.GymSpecializationId
		};
	}

	public static GymStaffSpecializationDTO ToDTO(this GymStaffSpecializationEntity source)
	{
		return new GymStaffSpecializationDTO()
		{
			Id = source.Id,
			GymStaffId = source.GymStaffId,
			GymSpecializationId = source.GymSpecializationId
		};
	}
}