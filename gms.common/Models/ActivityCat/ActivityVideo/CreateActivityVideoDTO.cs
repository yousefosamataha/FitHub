namespace gms.common.Models.ActivityCat.ActivityVideo;

public record struct CreateActivityVideoDTO
{
    public int ActivityId { get; init; }

    public required string VideoPath { get; init; }
}