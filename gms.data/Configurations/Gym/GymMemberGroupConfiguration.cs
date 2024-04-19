using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;
internal class GymMemberGroupConfiguration : IEntityTypeConfiguration<GymMemberGroupEntity>
{
    public void Configure(EntityTypeBuilder<GymMemberGroupEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMemberGroup", gmsDbProperties.DbSchema);

        builder.HasKey(gmg => gmg.Id);

        builder.HasOne(gmg => gmg.GymMemberUser)
               .WithMany(gu => gu.GymMemberGroups)
               .HasForeignKey(gmg => gmg.GymMemberUserId);

        builder.HasOne(gmg => gmg.GymGroup)
               .WithMany(gg => gg.GymMemberGroups)
               .HasForeignKey(gmg => gmg.GymGroupId);
    }
}
