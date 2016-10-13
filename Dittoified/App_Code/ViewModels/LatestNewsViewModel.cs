using System.Collections.Generic;
using System.Web;
using DittoDemo.Ditto.Processors;
using DittoDemo.Models;
using Our.Umbraco.Ditto;

namespace DittoDemo.ViewModels
{
    public class LatestNewsViewModel
    {
        [DittoCache(CacheDuration = 3000)]
        [LatestNews]
        public IEnumerable<NewsItemLink> NewsItems { get; set; }

        [NewsArchiveLink]
        public Link Archive { get; set; }
    }
}
