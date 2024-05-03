namespace gms.common.Models.GymCat.GymGroup;

public class GymGroupDTO
{
    public int Id { get; set; }
    public int BranchId { get; set; }
    public required string Name { get; set; }
    public string? Image { get; set; }
    public string? ImageType { get; set; }
}
