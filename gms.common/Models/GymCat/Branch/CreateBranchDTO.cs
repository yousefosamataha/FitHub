namespace gms.common.Models.GymCat.Branch;

public record CreateBranchDTO
{
    public int GymId { get; init; }
    public string BranchName { get; init; }
    public int? StartYear { get; init; }
    public required string Address { get; init; }
    public required string ContactNumber { get; init; }
    public int CountryId { get; init; }
    public required string Email { get; init; }
    public bool IsMainBranch { get; init; }
    public int GeneralSettingId { get; init; }
	public int? CreatedById { get; init; }
}
