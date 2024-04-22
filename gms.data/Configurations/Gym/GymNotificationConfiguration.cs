using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymNotificationConfiguration : IEntityTypeConfiguration<GymNotificationEntity>
{
    public void Configure(EntityTypeBuilder<GymNotificationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymNotification", gmsDbProperties.DbSchema);

        builder.HasKey(gn => gn.Id);

        builder.Property(gn => gn.NotificationTitle).IsRequired().HasMaxLength(256);

        builder.Property(gn => gn.NotificationMessageBody).IsRequired();

        builder.HasOne(gn => gn.GymBranch)
               .WithMany(gb => gb.GymNotifications)
               .HasForeignKey(gn => gn.BranchId);

        builder.HasOne(gn => gn.GymSenderUser)
               .WithMany(gu => gu.GymNotificationSenderUsers)
               .HasForeignKey(gn => gn.GymSenderUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(gn => gn.GymReceiverUser)
               .WithMany(gu => gu.GymNotificationReceiverUsers)
               .HasForeignKey(gn => gn.GymReceiverUserId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
