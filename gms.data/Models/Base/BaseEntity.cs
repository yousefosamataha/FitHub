namespace gms.data.Models.Base;
public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public int? CreatedById { get; set; }
    public bool IsDeleted { get; set; }
}
