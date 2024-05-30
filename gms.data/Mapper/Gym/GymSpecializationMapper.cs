using gms.common.Models.GymCat.GymSpecialization;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymSpecializationMapper
{
	public static GymSpecializationEntity ToEntity(this CreateGymSpecializationDTO source)
	{
		return new GymSpecializationEntity()
		{
			BranchId = source.BranchId,
			Name = source.Name,
		};
	}

	public static GymSpecializationDTO ToDTO(this GymSpecializationEntity source)
	{
		return new GymSpecializationDTO()
		{
			Id = source.Id,
			BranchId = source.BranchId,
			Name = source.Name
		};
	}
}
