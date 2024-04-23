namespace gms.common.Models.ActivityVideo;

public record struct UpdateActivityVideoDTO
{
    public int ActivityId { get; init; }

    public string VideoPath { get; init; }
}