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

        builder.Property(gss => gss.Name)
               .IsRequired()
               .HasMaxLength(256);

        builder.HasMany(gss => gss.GymUsers)
               .WithOne(gu => gu.GymStaffSpecialization)
               .HasForeignKey(gu => gu.GymStaffSpecializationId)
               .IsRequired(false);
    }
}
