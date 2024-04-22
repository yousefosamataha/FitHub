using gms.common.Constants;
using gms.data.Models.Nutrition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class MealIngredientConfiguration : IEntityTypeConfiguration<MealIngredientEntity>
{
    public void Configure(EntityTypeBuilder<MealIngredientEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".MealIngredient", gmsDbProperties.DbSchema);

        builder.HasKey(mi => mi.Id);

        builder.Property(mi => mi.Title).IsRequired().HasMaxLength(256);

        builder.Property(mi => mi.Calories).HasPrecision(18, 2);
        builder.Property(mi => mi.ServingSizeG).HasPrecision(18, 2);
        builder.Property(mi => mi.FatTotalG).HasPrecision(18, 2);
        builder.Property(mi => mi.FatSaturatedG).HasPrecision(18, 2);
        builder.Property(mi => mi.ProteinG).HasPrecision(18, 2);
        builder.Property(mi => mi.SodiumMg).HasPrecision(18, 2);
        builder.Property(mi => mi.PotassiumMg).HasPrecision(18, 2);
        builder.Property(mi => mi.CholesterolMg).HasPrecision(18, 2);
        builder.Property(mi => mi.CarbohydratesTotalG).HasPrecision(18, 2);
        builder.Property(mi => mi.FiberG).HasPrecision(18, 2);
        builder.Property(mi => mi.SugarG).HasPrecision(18, 2);

        builder.HasOne(mi => mi.NutritionPlanMeal)
               .WithMany(npm => npm.MealIngredients)
               .HasForeignKey(mi => mi.NutritionPlanMealId);
    }
}
