using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;

internal class GymConfiguration : IEntityTypeConfiguration<GymEntity>
{
	public void Configure(EntityTypeBuilder<GymEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".Gym", gmsDbProperties.DbSchema);

		builder.HasKey(g => g.Id);

		builder.Property(g => g.Name).IsRequired().HasMaxLength(256);
	}
}
