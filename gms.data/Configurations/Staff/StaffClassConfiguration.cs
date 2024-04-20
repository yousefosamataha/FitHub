using gms.common.Constants;
using gms.data.Models.Staff;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class StaffClassConfiguration : IEntityTypeConfiguration<StaffClassEntity>
{
    public void Configure(EntityTypeBuilder<StaffClassEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".StaffClass", gmsDbProperties.DbSchema);

        builder.HasKey(sc => sc.Id);

        //builder.HasOne(sc => sc.Gym)
        //       .WithMany()
        //       .HasForeignKey(sc => sc.GymId);

        //builder.HasOne(sc => sc.GymBranch)
        //       .WithMany()
        //       .HasForeignKey(sc => sc.BranchId);

        builder.HasOne(sc => sc.GymStaffUser)
               .WithMany()
               .HasForeignKey(sc => sc.StaffId);

        builder.HasOne(sc => sc.ClassSchedule)
               .WithMany(cs => cs.StaffClasses)
               .HasForeignKey(sc => sc.ClassScheduleId);
    }
}
