﻿using gms.common.Enums;
using gms.data.Models.Base;

namespace gms.data.Models.Subscription;

public class SubscriptionStatusEnumEntity : BaseEntity
{
    public required string SubscriptionStatus { get; set; }
    public required BadgeColorEnum BadgeColorId { get; set; }
}