﻿using gms.Application.Contracts.PagedResultToSelectTwo;

namespace gms.common.PagedResultToSelectTwo;

[Serializable]
public class PagedResultSelectDto<T> : ListResultSelectTwoDto<T>, IPagedResultToSelect<T>
{
    public long TotalCount { get; set; }

    public PagedResultSelectDto()
    {

    }
    public PagedResultSelectDto(long totalCount, IReadOnlyList<T> results)
        : base(results)
    {
        TotalCount = totalCount;
    }
}