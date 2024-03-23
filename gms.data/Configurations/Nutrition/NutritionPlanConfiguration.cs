//using gms.common.Constants;
//using gms.data.Models.Nutrition;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace gms.data.Configurations.Nutrition;

//internal class NutritionPlanConfiguration : IEntityTypeConfiguration<NutritionPlanEntity>
//{
//	public void Configure(EntityTypeBuilder<NutritionPlanEntity> builder)
//	{
//		builder.ToTable(gmsDbProperties.DbTablePrefix + ".NutritionPlan", gmsDbProperties.DbSchema);

//		builder.HasKey(np => np.Id);

//		// TODO: Run Migration
//		// builder.HasMany(np => np.NutritionPlanMeals)
//		// 	   .WithOne(npm => npm.NutritionPlan)
//		// 	   .HasForeignKey(npm => npm.NutritionPlanId);
//	}
//}
