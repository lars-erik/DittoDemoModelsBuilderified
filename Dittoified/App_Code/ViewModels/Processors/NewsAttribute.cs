using DittoDemo.Ditto.Processors.Contexts;
using DittoDemo.Models;
using Our.Umbraco.Ditto;
using System;
using System.Linq;
using System.Web;

namespace DittoDemo.Ditto.Processors
{
    [DittoProcessorMetaData(ContextType = typeof(NewsProcessorContext))]
    public class NewsAttribute : BaseNewsAttribute
    {
        public override object ProcessValue()
        {
            var currentPage = ((NewsProcessorContext)Context).CurrentPage;
            var pageSize = 2;

            var items = GetNews().ToList();
            var totalItems = items.Count;
            var totalPages = (long)Math.Ceiling(totalItems/(decimal)pageSize);

            currentPage = Math.Max(1, Math.Min(currentPage, totalPages));

            var pagedItems = items.Skip((int)(currentPage-1)*pageSize).Take(pageSize)
                .As<NewsPreviewLink>();

            return new PagedCollection<NewsPreviewLink>
            {
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalItems = totalItems,
                TotalPages = totalPages,
                Items = pagedItems
            };
        }
    }

    public class MyCacheKeyBuilder : DittoDefaultCacheKeyBuilder
    {
        public override string BuildCacheKey(DittoCacheContext context)
        {
            var key = base.BuildCacheKey(context);
            key += "_" + HttpContext.Current.Request.QueryString["p"];
            return key;
        }
    }
}
