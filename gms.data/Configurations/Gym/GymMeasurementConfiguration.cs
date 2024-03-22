using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;

internal class GymMeasurementConfiguration : IEntityTypeConfiguration<GymMeasurementEntity>
{
	public void Configure(EntityTypeBuilder<GymMeasurementEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymMeasurement", gmsDbProperties.DbSchema);

		builder.HasKey(gm => gm.Id);

		builder.Property(gm => gm.Result).HasPrecision(18, 2);

		builder.HasMany(gm => gm.MeasurementImages)
			   .WithOne(mi => mi.GymMeasurement)
			   .HasForeignKey(mi => mi.MeasurementId);
	}
}
