using gms.common.Models.Activity;
using gms.data.Models.Activity;

namespace gms.data.Mapper;

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

	public static ActivityVideoDTO ToDtos(this ActivityVideoEntity source)
	{
		return new ActivityVideoDTO()
		{
			ActivityVideoId = source.Id,
			ActivityId = source.ActivityId,
			VideoPath = source.VideoPath,
			Activity = source.Activity.ToDto()
		};
	}
}
