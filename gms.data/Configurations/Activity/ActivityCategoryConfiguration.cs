using gms.common.Constants;
using gms.data.Models.Activity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class ActivityCategoryConfiguration : IEntityTypeConfiguration<ActivityCategoryEntity>
{
    public void Configure(EntityTypeBuilder<ActivityCategoryEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".ActivityCategory", gmsDbProperties.DbSchema);

        builder.HasKey(ac => ac.Id);

        builder.Property(ac => ac.Name).IsRequired().HasMaxLength(100);

        builder.HasOne(ac => ac.GymBranch)
               .WithMany(gb => gb.ActivityCategories)
               .HasForeignKey(ac => ac.BranchId);

        builder.HasMany(ac => ac.Activities)
               .WithOne(a => a.ActivityCategory)
               .HasForeignKey(a => a.ActivityCategoryId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(ac => ac.IsDeleted == false);
    }
}