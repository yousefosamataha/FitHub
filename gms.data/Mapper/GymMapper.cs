using gms.common.Models.Gym;
using gms.data.Models.Gym;

namespace gms.data.Mapper;

public static class GymMapper
{
	public static GymEntity ToEntity(this CreateGymDTO source)
	{
		return new GymEntity()
		{
			Name = source.Name,
		};
	}

	public static GymDTO ToDto(this GymEntity source)
	{
		return new GymDTO()
		{
			Name = source.Name,
		};
	}
}
