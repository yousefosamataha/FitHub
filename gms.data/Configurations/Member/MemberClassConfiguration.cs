using gms.common.Constants;
using gms.data.Models.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Member;

internal class MemberClassConfiguration : IEntityTypeConfiguration<MemberClassEntity>
{
    public void Configure(EntityTypeBuilder<MemberClassEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".MemberClass", gmsDbProperties.DbSchema);

        builder.HasKey(mc => mc.Id);

        builder.HasOne(mc => mc.GymMemberUser)
               .WithMany()
               .HasForeignKey(mc => mc.GymMemberUserId);

        builder.HasOne(mc => mc.ClassSchedule)
               .WithMany(cs => cs.MemberClasses)
               .HasForeignKey(mc => mc.ClassScheduleId);
    }
}
