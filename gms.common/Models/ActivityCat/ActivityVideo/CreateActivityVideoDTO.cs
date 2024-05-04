namespace gms.common.Models.ActivityCat.ActivityVideo;

public record CreateActivityVideoDTO
{
    public int ActivityId { get; init; }

    public required string VideoPath { get; init; }
}