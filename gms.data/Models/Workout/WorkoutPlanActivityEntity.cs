﻿using gms.data.Models.Activity;
using gms.data.Models.Base;

namespace gms.data.Models.Workout;

public class WorkoutPlanActivityEntity : BaseEntity
{
	public int WorkoutPlanId { get; set; }
	public int ActivityId { get; set; }
	public int Sets { get; set; }
	public int Reps { get; set; }
	public double Kg { get; set; }
	public TimeSpan RestTime { get; set; }

	public virtual WorkoutPlanEntity WorkoutPlan { get; set; }
	public virtual ActivityEntity Activity { get; set; }

	// TODO: Add Relation Entities
	// public int WeekDayId { get; set; } 
}