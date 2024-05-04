using gms.common.Models.ActivityCat.Activity;
using gms.data.Models.Activity;

namespace gms.data.Mapper.Activity;

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

    public static ActivityDTO ToDTO(this ActivityEntity source)
    {
        return new ActivityDTO()
        {
            ActivityId = source.Id,
            Title = source.Title,
            BranchId = source.BranchId,
            ActivityCategoryId = source.ActivityCategoryId
        };
    }

    public static ActivityEntity ToUpdatedEntity(this UpdateActivityDTO source, ActivityEntity entity)
    {
        entity.Title = !string.IsNullOrWhiteSpace(source.Title) && !string.Equals(source.Title, entity.Title, StringComparison.OrdinalIgnoreCase) ? source.Title : entity.Title;
        entity.BranchId = source.BranchId > default(int) && source.BranchId != entity.BranchId ? source.BranchId : entity.BranchId;
        entity.ActivityCategoryId = source.ActivityCategoryId > default(int) && source.ActivityCategoryId != entity.ActivityCategoryId ? source.ActivityCategoryId : entity.ActivityCategoryId;
        return entity;
    }
}
