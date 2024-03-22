using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;

internal class MeasurementImageConfiguration : IEntityTypeConfiguration<MeasurementImageEntity>
{
	public void Configure(EntityTypeBuilder<MeasurementImageEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".MeasurementImage", gmsDbProperties.DbSchema);

		builder.HasKey(m => m.Id);
	}
}
