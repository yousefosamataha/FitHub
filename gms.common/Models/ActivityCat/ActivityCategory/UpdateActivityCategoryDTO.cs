﻿namespace gms.common.Models.ActivityCat.ActivityCategory;

public record struct UpdateActivityCategoryDTO
{
    public int BranchId { get; init; }

    public string Name { get; init; }
}