using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.GymInterestArea;
internal class GymInterestAreaEntityConfiguration : IEntityTypeConfiguration<GymInterestAreaEntity>
{
    public void Configure(EntityTypeBuilder<GymInterestAreaEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".gym_interest_area", gmsDbProperties.DbSchema);

        builder.Property(g => g.Interest).HasMaxLength(100);
    }
}
