﻿using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations;
internal class GymSpecializationConfiguration : IEntityTypeConfiguration<GymSpecializationEntity>
{
    public void Configure(EntityTypeBuilder<GymSpecializationEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymSpecialization", gmsDbProperties.DbSchema);

        builder.HasKey(gs => gs.Id);

        builder.Property(gs => gs.Name).IsRequired().HasMaxLength(256);

        builder.HasOne(gs => gs.GymBranch)
               .WithMany(gb => gb.GymSpecializations)
               .HasForeignKey(gs => gs.BranchId);

        builder.HasMany(gs => gs.GymStaffSpecializations)
               .WithOne(gss => gss.GymSpecialization)
               .HasForeignKey(gss => gss.GymSpecializationId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(gs => gs.IsDeleted == false);
    }
}
