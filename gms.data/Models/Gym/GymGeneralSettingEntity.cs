using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymGeneralSettingEntity : BaseEntity
{
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Chest { get; set; }
    public string Waist { get; set; }
    public string Thing { get; set; }
    public string Arms { get; set; }
    public string Fat { get; set; }
    public int ReminderDays { get; set; }
    public string ReminderMessage { get; set; }
    public bool IsShared { get; set; }
    public byte[]? ReportHeader { get; set; }
    public ImageTypeEnum? ReportHeaderTypeId { get; set; }
    public byte[]? ReportFooter { get; set; }
    public ImageTypeEnum? ReportFooterTypeId { get; set; }

    // Navigation properties
    public virtual ICollection<GymBranchEntity> GymBranches { get; set; }
}
