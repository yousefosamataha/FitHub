using gms.common.Constants;
using gms.data.Models.Nutrition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Nutrition;

internal class NutritionPlanConfiguration : IEntityTypeConfiguration<NutritionPlanEntity>
{
	public void Configure(EntityTypeBuilder<NutritionPlanEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".NutritionPlan", gmsDbProperties.DbSchema);

		builder.HasKey(wp => wp.Id);

		//builder.HasMany(wp => wp.WorkoutPlanActivities)
		//	   .WithOne(wpa => wpa.WorkoutPlan)
		//	   .HasForeignKey(wpa => wpa.WorkoutPlanId);
	}
}
