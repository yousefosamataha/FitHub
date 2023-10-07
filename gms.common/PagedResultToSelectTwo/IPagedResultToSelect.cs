using Volo.Abp.Application.Dtos;

namespace gms.common.PagedResultToSelectTwo;

public interface IPagedResultToSelect<T> : IListResultToSelect<T>, IHasTotalCount
{
}