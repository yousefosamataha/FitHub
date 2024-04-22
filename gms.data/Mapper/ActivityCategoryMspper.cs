using gms.common.Models.Activity;
using gms.data.Models.Activity;

namespace gms.data.Mapper;

public static class ActivityCategoryMspper
{
	public static ActivityCategoryEntity ToEntity(this CreateActivityCategoryDTO source)
	{
		return new ActivityCategoryEntity()
		{
			Name = source.Name,
			BranchId = source.BranchId
		};
	}

	public static ActivityCategoryDTO ToDto(this ActivityCategoryEntity source)
	{
		return new ActivityCategoryDTO()
		{
			ActivityCategoryId = source.Id,
			Name = source.Name,
			BranchId = source.BranchId,
			Activities = source.Activities.Select(a => a.ToDto()).ToList()
		};
	}
}
