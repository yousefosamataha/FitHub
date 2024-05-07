using gms.common.Models.ActivityCat.Activity;

namespace gms.common.Models.ActivityCat.ActivityVideo;

public record ActivityVideoDTO
{
    public required int ActivityVideoId { get; init; }

    public int ActivityId { get; init; }

    public required string VideoPath { get; init; }

    public ActivityDTO Activity { get; init; }
}
