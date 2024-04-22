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

	public static ActivityCategoryDTO ToDTO(this ActivityCategoryEntity source)
	{
		return new ActivityCategoryDTO()
		{
			ActivityCategoryId = source.Id,
			Name = source.Name,
			BranchId = source.BranchId,
			Activities = source.Activities.Select(a => a.ToDTO()).ToList()
		};
	}

	public static ActivityCategoryEntity ToUpdatedEntity(this UpdateActivityCategoryDTO source, ActivityCategoryEntity entity)
	{
		entity.Name = !string.IsNullOrWhiteSpace(source.Name) && !string.Equals(source.Name, entity.Name, StringComparison.OrdinalIgnoreCase) ? source.Name : entity.Name;
		entity.BranchId = source.BranchId > default(int) && source.BranchId != entity.BranchId ? source.BranchId : entity.BranchId;
		return entity;
	}
}
