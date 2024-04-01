using gms.data.Models.Base;
using gms.data.Models.Shared;

namespace gms.data.Models.Gym;

public class GymBranchEntity : BaseEntity
{
    public string BranchName { get; set; }
    public int StartYear { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public bool IsMainBranch { get; set; }
    public int GymId { get; set; }
    public int CountryId { get; set; }
    public int? GeneralSettingId { get; set; }
    public virtual CountryEntity Country { get; set; }
    public virtual GymEntity Gym { get; set; }
    public virtual GymGeneralSettingEntity GeneralSetting { get; set; }
    public virtual ICollection<GymBranchUsersEntity> GymBranchUsers { get; set;}
}
