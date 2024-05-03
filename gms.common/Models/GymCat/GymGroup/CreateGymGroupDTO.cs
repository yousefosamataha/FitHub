namespace gms.common.Models.GymCat.GymGroup;

public class CreateGymGroupDTO
{
    public int BranchId { get; set; }
    public required string Name { get; set; }
    public string? Image { get; set; }
    public string? ImageType { get; set; }
}
