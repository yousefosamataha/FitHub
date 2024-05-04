using gms.common.Constants;
using gms.data.Models.Nutrition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class NutritionPlanConfiguration : IEntityTypeConfiguration<NutritionPlanEntity>
{
    public void Configure(EntityTypeBuilder<NutritionPlanEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".NutritionPlan", gmsDbProperties.DbSchema);

        builder.HasKey(np => np.Id);

        builder.HasOne(np => np.GymBranch)
              .WithMany(gb => gb.NutritionPlans)
              .HasForeignKey(np => np.BranchId);

        builder.HasOne(np => np.GymMemberUser)
               .WithMany(gu => gu.MemberNutritionPlans)
               .HasForeignKey(np => np.GymMemberUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(np => np.GymStaffUser)
               .WithMany(gu => gu.StaffNutritionPlans)
               .HasForeignKey(np => np.AssignedByGymStaffUserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(np => np.NutritionPlanMeals)
               .WithOne(npm => npm.NutritionPlan)
               .HasForeignKey(npm => npm.NutritionPlanId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(np => np.IsDeleted == false);
    }
}
