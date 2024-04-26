namespace gms.common.Models.GymCat.Branch;

public record CreateBranchDTO
{
    public int GymId { get; set; }
    public string BranchName { get; set; }
    public int? StartYear { get; set; }
    public required string Address { get; set; }
    public required string ContactNumber { get; set; }
    public int CountryId { get; set; }
    public required string Email { get; set; }
    public bool IsMainBranch { get; set; }
    public int GeneralSettingId { get; set; }
}
