namespace gms.common.Models.ActivityCat.ActivityVideo;

public record ActivityVideoDTO
{
    public required int Id { get; init; }

    public int ActivityId { get; init; }

    public required string VideoPath { get; init; }
}
