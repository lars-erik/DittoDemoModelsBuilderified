using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsBuilderified.Models
{
    public partial class UmbNewsOverview : INewsArchivePaged
    {
        public IEnumerable<INewsItem> NewsPage { get; set; }
        public PageModel PageModel { get; set; }
    } 
}