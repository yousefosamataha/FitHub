﻿using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Shared;

public class GenderEnumEntity : BaseEntity
{
    public required string GenderName { get; set; }
    public required BadgeColorEnum BadgeColorId { get; set; }
}