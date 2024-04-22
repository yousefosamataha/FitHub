using gms.common.Models.Activity;
using gms.data.Models.Activity;

namespace gms.data.Mapper;

public static class ActivityMapper
{
	public static ActivityEntity ToEntity(this CreateActivityDTO source)
	{
		return new ActivityEntity()
		{
			Title = source.Title,
			BranchId = source.BranchId,
			ActivityCategoryId = source.ActivityCategoryId
		};
	}

	public static ActivityDTO ToDto(this ActivityEntity source)
	{
		return new ActivityDTO()
		{
			ActivityId = source.Id,
			Title = source.Title,
			BranchId = source.BranchId,
			ActivityCategoryId = source.ActivityCategoryId
		};
	}
}
