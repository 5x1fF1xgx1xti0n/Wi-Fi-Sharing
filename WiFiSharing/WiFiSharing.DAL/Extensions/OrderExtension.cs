namespace WiFiSharing.DAL.Extensions
{
    using System;
    using System.Linq;
    using System.Linq.Dynamic.Core;
    using WiFiSharing.DTOs.Filters;

    public static class OrderExtension
    {
        public static IQueryable<T> GetOrdered<T>(this IQueryable<T> source, OrderFilter filter)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            try
            {
                source = source.OrderBy($"{filter.OrderBy} {filter.OrderWay}");
            }
            catch (Exception ex)
            {
                throw;
            }

            return source;
        }
    }
}
