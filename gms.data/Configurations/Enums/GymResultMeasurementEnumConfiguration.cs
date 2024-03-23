using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Enums;

internal class GymResultMeasurementEnumConfiguration : IEntityTypeConfiguration<GymResultMeasurementEnumEntity>
{
	public void Configure(EntityTypeBuilder<GymResultMeasurementEnumEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymResultMeasurement", gmsDbProperties.DbSchema);

		builder.HasKey(gm => gm.Id);

		builder.Property(gm => gm.Id).ValueGeneratedNever();

		builder.Property(gm => gm.Name).IsRequired(true).HasMaxLength(100);

		builder.HasData(GetResultMeasurements());
	}
	public List<GymResultMeasurementEnumEntity> GetResultMeasurements()
	{
		List<GymResultMeasurementEnumEntity> resultMeasurements = new();
		foreach (var resultMeasurement in Enum.GetValues(typeof(GymResultMeasurementEnum)))
		{
			GymResultMeasurementEnumEntity newResultMeasurement = new()
			{
				Id = (byte)resultMeasurement,
				Name = resultMeasurement.ToString(),
				CreatedAt = DateTime.UtcNow
			};
			resultMeasurements.Add(newResultMeasurement);
		};
		return resultMeasurements;
	}
}
