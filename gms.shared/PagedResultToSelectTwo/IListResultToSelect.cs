namespace gms.shared.PagedResultToSelectTwo;

public interface IListResultToSelect<T>
{
    IReadOnlyList<T> Results { get; set; }
}
