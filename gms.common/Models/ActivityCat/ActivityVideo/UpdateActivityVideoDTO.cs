namespace gms.common.Models.ActivityCat.ActivityVideo;

public record UpdateActivityVideoDTO
{
    public int ActivityId { get; init; }

    public string VideoPath { get; init; }
}