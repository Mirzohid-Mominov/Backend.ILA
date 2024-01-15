using Caching.SimpleInfra.Domain.Common.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching.SimpleInfra.Application.Common.Extensions
{
    public static class LinqExtensions
    {
        public static IQueryable<TSource> ApplyPagination<TSource>(this IQueryable<TSource> source, FilterPagination poginationOptions)
        {
            return source.Skip((int)((poginationOptions.PageToken - 1) * poginationOptions.PageSize)).Take((int)poginationOptions.PageSize);
        }

        public static IEnumerable<TSource> ApplyPagination<TSource>(this IEnumerable<TSource> source, FilterPagination paginationOptions)
        {
            return source.Skip((int)((paginationOptions.PageToken - 1) * paginationOptions.PageSize)).Take((int)paginationOptions.PageSize);
        }
    }
}
