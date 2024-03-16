using gms.common.Constants;
using gms.data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Shared;

internal class CountryConfiguration : IEntityTypeConfiguration<CountryEntity>
{
	public void Configure(EntityTypeBuilder<CountryEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".Country", gmsDbProperties.DbSchema);

		builder.HasKey(p => p.Id);

		builder.Property(b => b.Id).ValueGeneratedNever();

		builder.Property(c => c.Name).IsRequired().HasMaxLength(256);

		builder.Property(c => c.Currency).IsRequired();
		
		builder.Property(c => c.Flag).IsRequired();

		builder.Property(c => c.Language).IsRequired().HasMaxLength(256);
		//builder.HasData(GetCountries());
	}

	public List<CountryEntity> GetCountries()
	{
		List<CountryEntity> countries = new();
		//countries.Add(new CountryEntity()
		//{
		//	Id = 1,
		//	Name = "Egypt",
		//	Flag = 
		//});
		return countries;
	}
}
