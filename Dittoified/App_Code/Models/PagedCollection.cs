using System.Collections.Generic;

namespace DittoDemo.Models
{
    public class PagedCollection
    {
        public long TotalItems { get; set; }
        public long CurrentPage { get; set; }
        public long PageSize { get; set; }
        public long TotalPages { get; set; }

        public bool IsFirstPage
        {
            get
            {
                return CurrentPage <= 1;
            }
        }

        public bool IsLastPage
        {
            get
            {
                return CurrentPage >= TotalPages;
            }
        }
    }

    public class PagedCollection<TResultType> : PagedCollection
    {
        public IEnumerable<TResultType> Items { get; set; }
    }
}
