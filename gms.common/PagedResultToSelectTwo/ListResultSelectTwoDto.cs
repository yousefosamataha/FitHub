namespace gms.common.PagedResultToSelectTwo;

[Serializable]
public class ListResultSelectTwoDto<T> : IListResultToSelect<T>
{
    private IReadOnlyList<T> _results;
    public IReadOnlyList<T> Results
    {
        get { return _results ?? (_results = new List<T>()); }
        set { _results = value; }
    }

    public ListResultSelectTwoDto()
    {

    }

    public ListResultSelectTwoDto(IReadOnlyList<T> results)
    {
        Results = results;
    }
}
