﻿using gms.common.Constants;
using gms.data.Models.Gym;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.data.Configurations.Gym;

internal class GymGroupConfiguration : IEntityTypeConfiguration<GymGroupEntity>
{
    public void Configure(EntityTypeBuilder<GymGroupEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".GymGroup", gmsDbProperties.DbSchema);

        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name).IsRequired().HasMaxLength(256);

        builder.HasOne(ggr => ggr.Gym)
               .WithMany(g => g.GymGroups)
               .HasForeignKey(ggr => ggr.GymId);
    }
}