using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class GymBranchConfiguration : IEntityTypeConfiguration<GymBranchEntity>
{
    public void Configure(EntityTypeBuilder<GymBranchEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymBranch", gmsDbProperties.DbSchema);

        builder.HasKey(gb => gb.Id);

        builder.Property(gb => gb.BranchName).IsRequired().HasMaxLength(256);

        builder.Property(gb => gb.StartYear).IsRequired();

        builder.Property(gb => gb.Address).IsRequired();

        builder.Property(gb => gb.ContactNumber).IsRequired();

        builder.Property(gb => gb.Email).IsRequired();

        builder.HasOne(gb => gb.Gym)
               .WithMany(g => g.GymBranches)
               .HasForeignKey(gb => gb.GymId);

        builder.HasOne(gb => gb.Country)
               .WithMany()
               .HasForeignKey(gb => gb.CountryId);

        builder.HasMany(gb => gb.GymUsers)
               .WithOne(gu => gu.GymBranch)
               .HasForeignKey(gu => gu.BranchId);

        builder.HasMany(gb => gb.GymSpecializations)
               .WithOne(gs => gs.GymBranch)
               .HasForeignKey(gs => gs.BranchId);

        builder.HasMany(gb => gb.GymMembershipPlans)
               .WithOne(gmp => gmp.GymBranch)
               .HasForeignKey(gmp => gmp.BranchId);

        builder.HasMany(gb => gb.ClassSchedules)
               .WithOne(cs => cs.GymBranch)
               .HasForeignKey(cs => cs.BranchId);

        builder.HasMany(gb => gb.GymLocations)
               .WithOne(gl => gl.GymBranch)
               .HasForeignKey(gl => gl.BranchId);

        builder.HasMany(gb => gb.GymGroups)
               .WithOne(ggr => ggr.GymBranch)
               .HasForeignKey(ggr => ggr.BranchId);

        builder.HasMany(gb => gb.Activities)
               .WithOne(a => a.GymBranch)
               .HasForeignKey(a => a.BranchId);

        builder.HasMany(gb => gb.ActivityCategories)
               .WithOne(ac => ac.GymBranch)
               .HasForeignKey(ac => ac.BranchId);

        builder.HasMany(gb => gb.WorkoutPlans)
               .WithOne(wp => wp.GymBranch)
               .HasForeignKey(wp => wp.BranchId);

        builder.HasMany(gb => gb.NutritionPlans)
               .WithOne(np => np.GymBranch)
               .HasForeignKey(np => np.BranchId);

        builder.HasMany(gb => gb.MealTimes)
               .WithOne(mt => mt.GymBranch)
               .HasForeignKey(mt => mt.BranchId);

        builder.HasMany(gb => gb.GymNotifications)
               .WithOne(gn => gn.GymBranch)
               .HasForeignKey(gn => gn.BranchId);

        builder.HasMany(gb => gb.GymEventReservations)
               .WithOne(gre => gre.GymBranch)
               .HasForeignKey(gre => gre.BranchId);

        //builder.HasOne(gb => gb.GeneralSetting)
        //       .WithOne(gg => gg.GymBranch)
        //       .HasForeignKey<GymBranchEntity>(gb => gb.GeneralSettingId);
    }
}
