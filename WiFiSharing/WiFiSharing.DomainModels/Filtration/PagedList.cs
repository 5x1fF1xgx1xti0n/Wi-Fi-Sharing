namespace WiFiSharing.DTOs.Filters
{
    using System.Collections.Generic;

    public class PagedList<T>
    {
        public List<T> TPageContent { get; set; }
        public PageFilter PageFilter { get; set; }
        public int TotalAmount { get; set; }
    }
}
