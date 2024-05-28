using gms.common.Models.GymCat.GymGeneralSetting;
using gms.common.Models.Shared.Country;

namespace gms.common.Models.GymCat.Branch;

public record GymBranchDTO
{
    public int Id { get; init; }
    public int GymId { get; set; }
    public required string BranchName { get; init; }
    public int? StartYear { get; init; }
    public required string Address { get; init; }
    public required string ContactNumber { get; init; }
    public int CountryId { get; init; }
    public required string Email { get; init; }
    public bool IsMainBranch { get; init; }
    public int GeneralSettingId { get; init; }
	public int? CreatedById { get; init; }
    public CountryDTO? Country { get; init; }
    public GeneralSettingDTO? GeneralSetting { get; init; }
}
