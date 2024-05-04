using gms.common.Models.ActivityCat.ActivityVideo;
using gms.data.Models.Activity;

namespace gms.data.Mapper.Activity;

public static class ActivityVideoMapper
{
    public static ActivityVideoEntity ToEntity(this CreateActivityVideoDTO source)
    {
        return new ActivityVideoEntity()
        {
            ActivityId = source.ActivityId,
            VideoPath = source.VideoPath
        };
    }

    public static ActivityVideoDTO ToDTO(this ActivityVideoEntity source)
    {
        return new ActivityVideoDTO()
        {
            ActivityVideoId = source.Id,
            ActivityId = source.ActivityId,
            VideoPath = source.VideoPath,
            Activity = source.Activity.ToDTO()
        };
    }

    public static ActivityVideoEntity ToUpdatedEntity(this UpdateActivityVideoDTO source, ActivityVideoEntity entity)
    {
        entity.VideoPath = !string.IsNullOrWhiteSpace(source.VideoPath) && !string.Equals(source.VideoPath, entity.VideoPath, StringComparison.OrdinalIgnoreCase) ? source.VideoPath : entity.VideoPath;
        entity.ActivityId = source.ActivityId > default(int) && source.ActivityId != entity.ActivityId ? source.ActivityId : entity.ActivityId;
        return entity;
    }
}
