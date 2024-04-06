using gms.common.Constants;
using gms.data.Models.Nutrition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class MealTimeConfiguration : IEntityTypeConfiguration<MealTimeEntity>
{
    public void Configure(EntityTypeBuilder<MealTimeEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".MealTime", gmsDbProperties.DbSchema);

        builder.HasKey(mt => mt.Id);

        builder.Property(mt => mt.Name).IsRequired().HasMaxLength(256);

        builder.HasMany(mt => mt.NutritionPlanMeals)
               .WithOne(npm => npm.MealTime)
               .HasForeignKey(npm => npm.MealTimeId);
    }
}
