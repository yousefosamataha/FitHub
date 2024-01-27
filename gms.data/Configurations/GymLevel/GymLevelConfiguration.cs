using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.GymLevel;
internal class GymLevelConfiguration : IEntityTypeConfiguration<GymLevelEntity>
{
	public void Configure(EntityTypeBuilder<GymLevelEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".gym_levels", gmsDbProperties.DbSchema);

		builder.HasData(GetGymLevels());

		builder.Property(g => g.Level).HasMaxLength(100);
	}
	public List<GymLevelEntity> GetGymLevels()
	{
		List<GymLevelEntity> levels = new();
		levels.AddRange(new List<GymLevelEntity>()
		{
			new GymLevelEntity()
			{
				Id = Guid.NewGuid(),
				Level = "Level 1",
				CreatedAt = DateTime.Now,
				IsDeleted = false
			}
		});
		return levels;
	}
}
