﻿namespace gms.common.Models.ClassCat.Class;

public record UpdateClassDTO
{
    public int Id { get; init; }
    public int BranchId { get; init; }
    public required string ClassName { get; init; }
    public int GymLocationId { get; init; }
    public decimal ClassFees { get; init; }
    public TimeOnly StartTime { get; init; }
    public TimeOnly EndTime { get; init; }
}
