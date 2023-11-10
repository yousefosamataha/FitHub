namespace gms.Application.Contracts.PagedResultToSelectTwo;

public interface IListResultToSelect<T>
{
    IReadOnlyList<T> Results { get; set; }
}
