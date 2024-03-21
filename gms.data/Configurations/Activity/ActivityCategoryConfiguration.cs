using gms.common.Constants;
using gms.data.Models.Activity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Activity;
internal class ActivityCategoryConfiguration : IEntityTypeConfiguration<ActivityCategoryEntity>
{
    public void Configure(EntityTypeBuilder<ActivityCategoryEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ActivityCategory", gmsDbProperties.DbSchema);

        builder.HasKey(ac => ac.Id);

        builder.Property(ac => ac.Name).IsRequired().HasMaxLength(100);
    }
}
