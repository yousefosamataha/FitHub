using gms.data.Models.Base;

namespace gms.data.Models.Gym;

public class GymGeneralSettingEntity : BaseEntity
{
    public byte[]? GymLogo { get; set; }
    public string Weight = "KG";
    public string Height = "Centimeter";
    public string Chest = "Inches";
    public string Waist = "Inches";
    public string Thing = "Inches";
    public string Arms = "Inches";
    public string Fat = "Percentage";
    public int ReminderDays = 5;
    public string ReminderMessage = "Hello {0},\r\n      Your Membership  {1}  started at {2} and it will expire on {3}.\r\nThank You.";
    public bool IsShared { get; set; }
    public byte[]? ReportHeader { get; set; }
    public byte[]? ReportFooter { get; set; }
}
