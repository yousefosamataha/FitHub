﻿namespace gms.common.Models.GymCat.GymGeneralSetting;

public record CreateGeneralSettingDTO
{
    public string Weight { get; init; }
    public string Height { get; init; }
    public string Chest { get; init; }
    public string Waist { get; init; }
    public string Thing { get; init; }
    public string Arms { get; init; }
    public string Fat { get; init; }
    public int ReminderDays { get; init; }
    public string ReminderMessage { get; init; }
    public bool IsShared { get; set; }
    public byte[]? ReportHeader { get; init; }
    public byte[]? ReportFooter { get; init; }
	public int? CreatedById { get; init; }
}
