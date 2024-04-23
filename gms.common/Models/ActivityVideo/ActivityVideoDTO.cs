using gms.common.Models.Activity;

namespace gms.common.Models.ActivityVideo;

public record struct ActivityVideoDTO
{
    public required int ActivityVideoId { get; init; }

    public int ActivityId { get; init; }

    public required string VideoPath { get; init; }

    public ActivityDTO Activity { get; init; }
}
