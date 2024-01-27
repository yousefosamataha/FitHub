using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.GymGroup;
internal class GymGroupConfiguration : IEntityTypeConfiguration<GymGroupEntity>
{
	public void Configure(EntityTypeBuilder<GymGroupEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".gym_group", gmsDbProperties.DbSchema);

		builder.Property(g => g.Name).HasMaxLength(200);

		builder.Property(g => g.Image).HasMaxLength(255);
	}
}
