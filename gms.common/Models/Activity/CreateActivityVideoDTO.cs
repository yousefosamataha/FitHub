namespace gms.common.Models.Activity;

public record struct CreateActivityVideoDTO
{
	public int ActivityId { get; init; }

	public required string VideoPath { get; init; }
}