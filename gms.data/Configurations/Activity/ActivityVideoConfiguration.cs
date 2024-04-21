using gms.common.Constants;
using gms.data.Models.Activity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class ActivityVideoConfiguration : IEntityTypeConfiguration<ActivityVideoEntity>
{
    public void Configure(EntityTypeBuilder<ActivityVideoEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ActivityVideo", gmsDbProperties.DbSchema);

        builder.HasKey(av => av.Id);

        builder.Property(av => av.VideoPath).IsRequired();

        builder.HasOne(av => av.Activity)
               .WithMany(a => a.ActivityVideos)
               .HasForeignKey(av => av.ActivityId);
    }
}
