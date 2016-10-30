using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsBuilderified.Models
{
    public class PageModel
    {
        public long TotalItems { get; set; }
        public long CurrentPage { get; set; }
        public int PageSize { get; set; }
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
}