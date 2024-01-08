namespace gms.common.PagedResultToSelectTwo;

public interface IListResultToSelect<T>
{
    IReadOnlyList<T> Results { get; set; }
}
