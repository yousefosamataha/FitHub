using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;
internal class GymNotificationConfiguration : IEntityTypeConfiguration<GymNotificationEntity>
{
    public void Configure(EntityTypeBuilder<GymNotificationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymNotification", gmsDbProperties.DbSchema);

        builder.HasKey(gn => gn.Id);

        builder.Property(gn => gn.NotificationTitle)
               .IsRequired()
               .HasMaxLength(256);

        builder.Property(gn => gn.NotificationMessageBody).IsRequired();
    }
}
