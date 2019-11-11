namespace WiFiSharing.DAL.Extensions
{
    using System;
    using System.Linq;
    using System.Linq.Dynamic.Core;
    using WiFiSharing.DTOs.Filters;

    public static class SearchExtension
    {
        public static IQueryable<T> Search<T>(this IQueryable<T> source, SearchFilter filter)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            try
            {
                if (string.IsNullOrEmpty(filter.SearchField))
                {
                    source = source
                        .Where(x => x.GetType()
                                     .GetProperties()
                                     .AsQueryable()
                                     .Any(p => p.ToString()
                                        .Contains(filter.SearchData)));
                }
                else
                {
                    source = source.Where($"{filter.SearchField}.Contains(@0)", filter.SearchData);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return source;
        }
    }
}
