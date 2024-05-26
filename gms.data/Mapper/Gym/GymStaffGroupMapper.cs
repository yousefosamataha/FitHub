using gms.common.Models.GymCat.GymStaffGroup;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymStaffGroupMapper
{
	public static GymStaffGroupEntity ToEntity(this CreateGymStaffGroupDTO source)
	{
		return new GymStaffGroupEntity()
		{
			GymStaffUserId = source.GymStaffUserId,
			GymGroupId = source.GymGroupId
		};
	}

	public static GymStaffGroupDTO ToDTO(this GymStaffGroupEntity source)
	{
		return new GymStaffGroupDTO()
		{
			Id = source.Id,
			GymStaffUserId = source.GymStaffUserId,
			GymGroupId = source.GymGroupId
		};
	}
}
