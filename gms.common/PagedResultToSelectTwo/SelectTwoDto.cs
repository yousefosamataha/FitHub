namespace gms.common.PagedResultToSelectTwo;

public abstract class SelectTwoBaseDto<TId>
{
    public TId Id { get; set; }

    public SelectTwoBaseDto(TId id) => Id = id;
    
    public class StructDto<T> : SelectTwoBaseDto<T> where T : struct
    {
        public StructDto() : base(default) { }
    }
    public class StringDto : SelectTwoBaseDto<string>
    {
        public StringDto(string id) : base(id) { }
    }
    public class GuidDto : SelectTwoBaseDto<Guid>
    {
        public GuidDto(Guid id) : base(id) { }
    }

}

public class SelectTwoDto<TId> : SelectTwoBaseDto<TId> 
{
    public string Text { get; set; }
    
    public bool? Disabled { get; set; }
    
    public bool? Selected { get; set; }

    public SelectTwoDto(TId id) : base(id)
    {
        Id = id;
    }
    
}
