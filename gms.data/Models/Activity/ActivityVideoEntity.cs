using gms.data.Models.Base;

namespace gms.data.Models.Activity;
public class ActivityVideoEntity : BaseEntity
{
	public int ActivityId { get; set; }

	public required string VideoPath { get; set; }

	// Navigation properties
	public virtual ActivityEntity Activity { get; set; }
}
