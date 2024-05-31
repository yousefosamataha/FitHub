using gms.common.Models.GymCat.Branch;
using gms.common.Models.Identity.User;

namespace gms.common.Models.GymCat.GymNotification;

public sealed record GymNotificationDTO
{
	public int Id { get; init; }

	public int BranchId { get; init; }

	public int GymSenderUserId { get; init; }

	public int GymReceiverUserId { get; init; }

	public required string NotificationTitle { get; init; }

	public required string NotificationMessageBody { get; init; }

	public required bool IsReaded { get; init; }

	public DateTime SendDate { get; init; }

	public GymUserDTO GymSenderUser { get; init; }

	public GymUserDTO GymReceiverUser { get; init; }

	public GymBranchDTO GymBranch { get; init; }
}