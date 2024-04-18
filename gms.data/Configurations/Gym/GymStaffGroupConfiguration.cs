using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;
internal class GymStaffGroupConfiguration : IEntityTypeConfiguration<GymStaffGroupEntity>
{
    public void Configure(EntityTypeBuilder<GymStaffGroupEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymStaffGroup", gmsDbProperties.DbSchema);

        builder.HasKey(gsg => gsg.Id);

        builder.HasOne(gsg => gsg.GymGroup)
               .WithMany(gg => gg.GymStaffGroups)
               .HasForeignKey(gsg => gsg.GymGroupId);

        builder.HasOne(gsg => gsg.GymStaffUser)
               .WithMany(gu => gu.GymStaffGroups)
               .HasForeignKey(gsg => gsg.GymStaffUserId);
    }
}
