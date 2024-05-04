namespace gms.common.ViewModels.Gym;

public class GymGroupVM
{
	public int Id { get; set; }
	public int BranchId { get; set; }
	public required string Name { get; set; }
	public string? Image { get; set; }
	public string? ImageType { get; set; }
}
