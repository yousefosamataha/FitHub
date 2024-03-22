using gms.common.Constants;
using gms.data.Models.Activity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Activity;
internal class ActivityConfiguration : IEntityTypeConfiguration<ActivityEntity>
{
    public void Configure(EntityTypeBuilder<ActivityEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".Activity", gmsDbProperties.DbSchema);

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Title).IsRequired().HasMaxLength(256);

        builder.HasOne(a => a.ActivityCategory)
               .WithMany(ac => ac.Activities)
               .HasForeignKey(a => a.ActivityCategoryId);

        builder.HasMany(a => a.MembershipActivities)
               .WithOne(ma => ma.Activity)
               .HasForeignKey(ma => ma.ActivityId);

        builder.HasMany(a => a.ActivityVideos)
               .WithOne(av => av.Activity)
               .HasForeignKey(av => av.ActivityId);

        builder.HasMany(a => a.WorkoutPlanActivities)
               .WithOne(wpa => wpa.Activity)
               .HasForeignKey(wpa => wpa.ActivityId);
    }
}
