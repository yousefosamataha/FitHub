using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymGeneralSettingEntity : BaseEntity
{
    public required string Weight = "KG";
    public required string Height = "Centimeter";
    public required string Chest = "Inches";
    public required string Waist = "Inches";
    public required string Thing = "Inches";
    public required string Arms = "Inches";
    public required string Fat = "Percentage";
    public int ReminderDays = 5;
    public required string ReminderMessage = "Hello {0},\r\n      Your Membership  {1}  started at {2} and it will expire on {3}.\r\nThank You.";
    public bool IsShared { get; set; }
    public byte[]? ReportHeader { get; set; }
    public byte[]? ReportFooter { get; set; }

    // Navigation properties
    public virtual ICollection<GymBranchEntity> GymBranches { get; set; }
}
