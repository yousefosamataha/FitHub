using Volo.Abp.Application.Dtos;

namespace gms.shared.PagedResultToSelectTwo;

public interface IPagedResultToSelect<T> : IListResultToSelect<T>, IHasTotalCount
{
}