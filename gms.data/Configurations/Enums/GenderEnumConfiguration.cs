using gms.common.Constants;
using gms.common.Enums;
using gms.data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Enums;

internal class GenderEnumConfiguration : IEntityTypeConfiguration<GenderEnumEntity>
{

	public void Configure(EntityTypeBuilder<GenderEnumEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".GenderEnum", gmsDbProperties.DbSchema);

		builder.HasKey(g => g.Id);

		builder.Property(g => g.Id).ValueGeneratedNever();

		builder.Property(g => g.GenderName).IsRequired(true).HasMaxLength(100); ;

		builder.HasData(GetGenderEnumValues());
	}

	public List<GenderEnumEntity> GetGenderEnumValues()
	{
		List<GenderEnumEntity> genderEnumValues = new();

		foreach (var genderValue in Enum.GetValues(typeof(GenderEnum)))
		{
			GenderEnumEntity newGenderEnumValue = new()
			{
				Id = (byte)genderValue,
				GenderName = genderValue.ToString(),
				BadgeColorId = (byte)genderValue switch
				{
					1 => BadgeColorEnum.primary,
					2 => BadgeColorEnum.female
				},
				CreatedAt = DateTime.UtcNow
			};
			genderEnumValues.Add(newGenderEnumValue);
		};
		return genderEnumValues;
	}
}
