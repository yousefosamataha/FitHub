﻿using gms.common.Constants;
using gms.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gms.entityframeworkcore.Configurations.User;
internal class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable(gmsDbProperties.DbTablePrefix + ".user", gmsDbProperties.DbSchema);

        builder.Property(a => a.Name).IsRequired().HasMaxLength(250);
    }
}