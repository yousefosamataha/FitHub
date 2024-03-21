using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Enums;

internal class MemberLevelEnumConfiguration : IEntityTypeConfiguration<MemberLevelEnumEntity>
{
	public void Configure(EntityTypeBuilder<MemberLevelEnumEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".MemberLevelEnum", gmsDbProperties.DbSchema);

		builder.HasKey(ml => ml.Id);

		builder.Property(g => g.Id).ValueGeneratedNever();

		builder.Property(ml => ml.LevelName).IsRequired(true).HasMaxLength(100);

		builder.HasData(GetMemberLevels());
	}
	public List<MemberLevelEnumEntity> GetMemberLevels()
	{
		List<MemberLevelEnumEntity> memberLevels = new();
		foreach (var memberLevel in Enum.GetValues(typeof(MemberLevelEnum)))
		{
			MemberLevelEnumEntity newMemberLevel = new()
			{
				Id = (byte)memberLevel,
				LevelName = memberLevel.ToString(),
				CreatedAt = DateTime.UtcNow
			};
			memberLevels.Add(newMemberLevel);
		};
		return memberLevels;
	}
}
