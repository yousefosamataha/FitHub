namespace gms.common.Models.Activity;

public record struct UpdateActivityVideoDTO
{
	public int ActivityId { get; init; }

	public string VideoPath { get; init; }
}