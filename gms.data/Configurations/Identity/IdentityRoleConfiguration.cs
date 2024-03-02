//using gms.common.Constants;
//using gms.common.Enums;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace gms.data.Configurations.Identity;
//internal class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
//{
//	public void Configure(EntityTypeBuilder<IdentityRole> builder)
//	{
//		builder.ToTable(gmsDbProperties.DbIdentityTablePrefix + ".Role", gmsDbProperties.DbSchema);
//		builder.HasData(GetSystemRoles());
//	}
//	public List<IdentityRole> GetSystemRoles()
//	{
//		List<IdentityRole> roles = new();
//		foreach (var role in Enum.GetValues(typeof(RolesEnum)))
//		{
//			IdentityRole newRole = new()
//			{
//				Name = role.ToString(),
//				NormalizedName = role.ToString().ToUpper()
//			};
//			roles.Add(newRole);
//		};
//		return roles;
//	}
//}
