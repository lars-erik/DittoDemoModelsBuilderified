using System.Activities.Expressions;
using DittoDemo.Ditto.Processors;
using DittoDemo.Models;
using Our.Umbraco.Ditto;

namespace DittoDemo.ViewModels
{
    public class NewsOverviewViewModel
    {
        [Title]
        public string Title { get; set; }
        
        [DittoCache(CacheDuration = 300, CacheKeyBuilderType = typeof(MyCacheKeyBuilder))]
        [News]
        public PagedCollection<NewsPreviewLink> NewsItems { get; set; }
    }
}
