using gms.data.Models.Base;
using gms.data.Models.Identity;

namespace gms.data.Models.Gym;
public class GymNotificationEntity : BaseEntity
{
    public int BranchId { get; set; }
    public int GymSenderUserId { get; set; }
    public int GymReceiverUserId { get; set; }
    public required string NotificationTitle { get; set; }
    public required string NotificationMessageBody { get; set; }
    public required bool IsReaded { get; set; }
    public DateTime SendDate { get; set; }

    // Navigation properties
    public virtual GymUserEntity GymSenderUser { get; set; }
    public virtual GymUserEntity GymReceiverUser { get; set; }
    public virtual GymBranchEntity GymBranch { get; set; }
}
