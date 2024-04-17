using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;
internal class GymStaffSpecializationConfiguration : IEntityTypeConfiguration<GymStaffSpecializationEntity>
{
    public void Configure(EntityTypeBuilder<GymStaffSpecializationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymStaffSpecialization", gmsDbProperties.DbSchema);

        builder.HasKey(gss => gss.Id);

        builder.HasOne(gss => gss.GymSpecialization)
               .WithMany(gs => gs.GymStaffSpecializations)
               .HasForeignKey(gss => gss.GymSpecializationId);


        builder.HasOne(gss => gss.GymStaff)
               .WithMany(gs => gs.GymStaffSpecializations)
               .HasForeignKey(gss => gss.GymStaffId);

    }
}
