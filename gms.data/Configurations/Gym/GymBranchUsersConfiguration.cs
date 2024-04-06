//using gms.common.Constants;
//using gms.data.Models.Gym;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace gms.data.Configurations;
//internal class GymBranchUsersConfiguration : IEntityTypeConfiguration<GymBranchUsersEntity>
//{
//    public void Configure(EntityTypeBuilder<GymBranchUsersEntity> builder)
//    {
//        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymBranchUsers", gmsDbProperties.DbSchema);

//        builder.HasKey(gbu => gbu.Id);

//        builder.HasOne(gbu => gbu.GymBranch)
//               .WithMany(gb => gb.GymBranchUsers)
//               .HasForeignKey(gbu => gbu.GymBranchId);

//        builder.HasOne(gbu => gbu.GymUser)
//               .WithMany(gu => gu.GymBranchUsers)
//               .HasForeignKey(gbu => gbu.GymUserId);
//    }
//}
