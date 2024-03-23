using gms.common.Constants;
using gms.data.Models.Nutrition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Nutrition;

internal class NutritionPlanMealConfiguration : IEntityTypeConfiguration<NutritionPlanMealEntity>
{
    public void Configure(EntityTypeBuilder<NutritionPlanMealEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".NutritionPlanMeal", gmsDbProperties.DbSchema);

        builder.HasKey(npm => npm.Id);

        builder.HasOne(npm => npm.NutritionPlan)
               .WithMany(np => np.NutritionPlanMeals)
               .HasForeignKey(npm => npm.NutritionPlanId);

        builder.HasOne(npm => npm.MealTime)
               .WithMany(mt => mt.NutritionPlanMeals)
               .HasForeignKey(npm => npm.MealTimeId);

        builder.HasMany(npm => npm.MealIngredients)
               .WithOne(mi => mi.NutritionPlanMeal)
               .HasForeignKey(mi => mi.MealId);
    }
}
