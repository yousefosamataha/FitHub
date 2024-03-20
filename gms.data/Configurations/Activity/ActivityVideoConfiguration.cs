using gms.common.Constants;
using gms.data.Models.Activity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Activity;
internal class ActivityVideoConfiguration : IEntityTypeConfiguration<ActivityVideoEntity>
{
    public void Configure(EntityTypeBuilder<ActivityVideoEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ActivityVideo", gmsDbProperties.DbSchema);

        builder.HasKey(ac => ac.Id);

        builder.Property(ac => ac.VideoPath).IsRequired();
    }
}
