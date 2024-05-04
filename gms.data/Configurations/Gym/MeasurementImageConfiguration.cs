using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class MeasurementImageConfiguration : IEntityTypeConfiguration<MeasurementImageEntity>
{
	public void Configure(EntityTypeBuilder<MeasurementImageEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".MeasurementImage", gmsDbProperties.DbSchema);

		builder.HasKey(m => m.Id);

		builder.HasOne(mi => mi.GymMeasurement)
			   .WithMany(gm => gm.MeasurementImages)
			   .HasForeignKey(mi => mi.GymMeasurementId);

        builder.HasQueryFilter(mi => mi.IsDeleted == false);
    }
}
