using gms.common.Constants;
using gms.data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;

internal class CountryConfiguration : IEntityTypeConfiguration<CountryEntity>
{
	public void Configure(EntityTypeBuilder<CountryEntity> builder)
	{
		builder.ToTable(gmsDbProperties.DbTablePrefix + ".Country", gmsDbProperties.DbSchema);

		builder.HasKey(p => p.Id);

		builder.Property(b => b.Id).ValueGeneratedNever();

		builder.Property(c => c.Name).IsRequired().HasMaxLength(256);

		builder.Property(c => c.Currency).IsRequired();

		builder.Property(c => c.TimeZone).IsRequired();

		builder.Property(c => c.Language).IsRequired().HasMaxLength(256);
		
		builder.Property(c => c.Flag).IsRequired();

        builder.HasMany(c => c.GymBranches)
               .WithOne(gb => gb.Country)
               .HasForeignKey(gb => gb.CountryId);

        builder.HasData(GetCountries());
	}

	public List<CountryEntity> GetCountries()
	{
		List<CountryEntity> countries = new();
		countries.Add(new CountryEntity()
		{
			Id = 1,
			Name = "Egypt",
			Currency = "EGP",
            TimeZone = "",
            Language = "ar-EG",
			Flag = Convert.FromBase64String("data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iaXNvLTg4NTktMSI/Pg0KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPg0KPHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB2ZXJzaW9uPSIxLjEiIGlkPSJMYXllcl8xIiB4PSIwcHgiIHk9IjBweCIgdmlld0JveD0iMCAwIDUxMiA1MTIiIHN0eWxlPSJlbmFibGUtYmFja2dyb3VuZDpuZXcgMCAwIDUxMiA1MTI7IiB4bWw6c3BhY2U9InByZXNlcnZlIj4NCjxyZWN0IHk9IjAuMDY5IiBzdHlsZT0iZmlsbDojRkY0QjU1OyIgd2lkdGg9IjUxMiIgaGVpZ2h0PSIxNzAuNTgiLz4NCjxyZWN0IHk9IjM0MS4yMjEiIHN0eWxlPSJmaWxsOiM0NjQ2NTU7IiB3aWR0aD0iNTEyIiBoZWlnaHQ9IjE3MC43MSIvPg0KPHJlY3QgeT0iMTcwLjY1MSIgc3R5bGU9ImZpbGw6I0Y1RjVGNTsiIHdpZHRoPSI1MTIiIGhlaWdodD0iMTcwLjU4Ii8+DQo8cGF0aCBzdHlsZT0iZmlsbDojRjBDNzI3OyIgZD0iTTI5My43OSwyMzIuNTY4YzAtNS44NjktNS43NS0xMC4wMTMtMTEuMzE4LTguMTU3bC0xMC40NjIsMy40ODdsLTIuNTQtMTUuMzQyICBjLTEuNTE5LTkuMTUyLTkuMzYxLTE1Ljc5NS0xOC42NDMtMTUuNzk1aC05Ljc4NmwtMTAuMjM1LDEyLjU5N2gxMy41NTJsLTMuNzkzLDE4LjczM2wtMTEuMDM4LTMuNjggIGMtNS41NjgtMS44NTYtMTEuMzE4LDIuMjg4LTExLjMxOCw4LjE1N3Y2My42NWwxNS4yMzQtMTUuMjM0bC03LjE3OSwyMS41MzNoLTguMDU2djEyLjU5N2g3NS41OHYtMTIuNTk3aC04LjA1NmwtNy4xNzktMjEuNTMzICBsMTUuMjM0LDE1LjIzNHYtNjMuNjVMMjkzLjc5LDIzMi41NjhMMjkzLjc5LDIzMi41Njh6IE0yNDkuNzAyLDMwMi41MTZoLTEwLjE1NWw2Ljk4My0xOC42NDhsMy4xNzIsNC4wNTFWMzAyLjUxNnogICBNMjYyLjI5OCwzMDIuNTE2di0xNC41OTdsMy4xNzItNC4wNTFsNi45ODMsMTguNjQ4TDI2Mi4yOTgsMzAyLjUxNkwyNjIuMjk4LDMwMi41MTZ6IE0yNTYsMjc5LjY4NWMwLDAtMTkuNDg1LTEzLjE4Ny0xOC42OTgtMzcuNzkgIGMwLDAsMTIuMDA2LTEuOTY4LDE4LjY5OC0xMi41OTdjNi42OTIsMTAuNjI4LDE4LjY5OCwxMi41OTcsMTguNjk4LDEyLjU5N0MyNzUuNDg1LDI2Ni40OTgsMjU2LDI3OS42ODUsMjU2LDI3OS42ODV6Ii8+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8Zz4NCjwvZz4NCjxnPg0KPC9nPg0KPGc+DQo8L2c+DQo8L3N2Zz4NCg=="),
		});
		return countries;
	}
}
