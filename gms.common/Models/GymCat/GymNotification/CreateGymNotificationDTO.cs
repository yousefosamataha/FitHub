namespace gms.common.Models.GymCat.GymNotification;

public sealed record CreateGymNotificationDTO
{
	public int BranchId { get; init; }

	public int GymSenderUserId { get; init; }

	public int GymReceiverUserId { get; init; }

	public required string NotificationTitle { get; init; }

	public required string NotificationMessageBody { get; init; }

	public required bool IsReaded { get; init; }

	public DateTime SendDate { get; init; }
}
