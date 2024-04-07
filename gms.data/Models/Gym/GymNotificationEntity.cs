using gms.data.Models.Base;

namespace gms.data.Models.Gym;
public class GymNotificationEntity : BaseEntity
{
    public required string NotificationTitle { get; set; }
    public required string NotificationMessageBody { get; set; }
    public required bool IsReaded { get; set; }
    public DateTime SendDate { get; set; }

    //TODO: Add Relation Entities
    //public int SenderId { get; set; }
    //public int ReceiverId { get; set; }
    //public GymUser Sender { get; set; } // Assuming a GymUser entity represents the sender
    //public GymUser Receiver { get; set; }
    //public int GymId {get;set;}
    //public virtual GymEntity Gym { get; set; }
}
