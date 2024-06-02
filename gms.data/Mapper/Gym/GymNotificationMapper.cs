using gms.common.Models.GymCat.GymNotification;
using gms.data.Mapper.Identity;
using gms.data.Models.Gym;

namespace gms.data.Mapper.Gym;

public static class GymNotificationMapper
{
	public static GymNotificationEntity ToEntity(this CreateGymNotificationDTO source)
	{
		return new GymNotificationEntity()
		{
			BranchId = source.BranchId,
			GymReceiverUserId = source.GymReceiverUserId,
			GymSenderUserId = source.GymSenderUserId,
			NotificationTitle = source.NotificationTitle,
			SendDate = source.SendDate,
			NotificationMessageBody = source.NotificationMessageBody,
			IsReaded = source.IsReaded
		};
	}

	public static GymNotificationDTO ToDTO(this GymNotificationEntity source)
	{
		return new GymNotificationDTO()
		{
			Id = source.Id,
			BranchId = source.BranchId,
			GymReceiverUserId = source.GymReceiverUserId,
			GymSenderUserId = source.GymSenderUserId,
			NotificationTitle = source.NotificationTitle,
			SendDate = source.SendDate,
			NotificationMessageBody = source.NotificationMessageBody,
			IsReaded = source.IsReaded,
			GymBranch = source.GymBranch.ToDTO(),
			GymReceiverUser = source.GymReceiverUser.ToDTO(),
			GymSenderUser = source.GymSenderUser.ToDTO()
		};
	}

	public static GymNotificationEntity ToUpdatedEntity(this UpdateGymNotificationDTO source, GymNotificationEntity entity)
	{
		entity.NotificationTitle = !string.IsNullOrWhiteSpace(source.NotificationTitle) &&
								   !string.Equals(source.NotificationTitle, entity.NotificationTitle, StringComparison.OrdinalIgnoreCase)
								   ? source.NotificationTitle : entity.NotificationTitle;

		entity.NotificationMessageBody = !string.IsNullOrWhiteSpace(source.NotificationMessageBody) &&
										 !string.Equals(source.NotificationMessageBody, entity.NotificationMessageBody, StringComparison.OrdinalIgnoreCase)
										 ? source.NotificationMessageBody : entity.NotificationMessageBody;

		entity.SendDate = !entity.SendDate.Equals(source.SendDate) &&
						   source.SendDate > DateTime.UtcNow
						   ? source.SendDate : entity.SendDate;

		entity.GymReceiverUserId = entity.GymReceiverUserId != source.GymReceiverUserId &&
								   source.GymReceiverUserId > 0
								   ? source.GymReceiverUserId : entity.GymReceiverUserId;
		return entity;
	}
}