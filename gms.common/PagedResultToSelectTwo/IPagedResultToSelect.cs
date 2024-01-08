using gms.common.PagedResultToSelectTwo;
using Volo.Abp.Application.Dtos;

namespace gms.Application.Contracts.PagedResultToSelectTwo;

public interface IPagedResultToSelect<T> : IListResultToSelect<T>, IHasTotalCount
{
}