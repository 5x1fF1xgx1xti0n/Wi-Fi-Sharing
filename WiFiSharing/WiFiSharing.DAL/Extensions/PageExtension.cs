namespace WiFiSharing.DAL.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;
    using WiFiSharing.DTOs.Filters;

    public static class PageExtension
    {
        public async static Task<PagedList<T>> GetPage<T>(this IQueryable<T> query, PageFilter filter)
        {
            var page = new PagedList<T>();
            page.PageFilter = filter;

            var skip = (filter.PageIndex - 1) * filter.PageSize;

            page.TPageContent = await query
                .Skip(skip)
                .Take(filter.PageSize)
                .ToListAsync();

            return page;
        }
    }
}
