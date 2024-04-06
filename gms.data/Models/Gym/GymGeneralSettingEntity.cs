using gms.data.Models.Base.Entities;

namespace gms.data.Models.Gym;

public class GymGeneralSettingEntity : BaseEntity
{
    public byte[] GymLogo { get; set; }
    public string? Weight { get; set; }
    public string? Height { get; set; }
    public string? Chest { get; set; }
    public string? Waist { get; set; }
    public string? Thing { get; set; }
    public string? Arms { get; set; }
    public string? Fat { get; set; }
    public int ReminderDays { get; set; }
    public string ReminderMessage { get; set; }
    public bool IsShared { get; set; }
    public byte[] ReportHeader { get; set; }
    public byte[] ReportFooter { get; set; }
    public int? GymId { get; set; }
    public int? BranchId { get; set; }
    public virtual GymEntity Gym { get; set; }
    public virtual GymBranchEntity GymBranch { get; set; }
}
