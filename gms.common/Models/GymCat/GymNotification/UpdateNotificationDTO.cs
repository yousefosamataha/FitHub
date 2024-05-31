namespace gms.common.Models.GymCat.GymNotification;

public sealed record UpdateGymNotificationDTO
{
	public int GymReceiverUserId { get; init; }

	public required string NotificationTitle { get; init; }

	public required string NotificationMessageBody { get; init; }

	public DateTime SendDate { get; init; }
}
