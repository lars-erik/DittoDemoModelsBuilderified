using System;
using System.Collections.Generic;
using System.Linq;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo.Ditto.Processors
{
    public abstract class BaseNewsAttribute : DittoProcessorAttribute
    {
        protected IEnumerable<IPublishedContent> GetNews()
        {
            var content = Value as IPublishedContent;
            if (content == null) return Enumerable.Empty<IPublishedContent>();

            var homePage = content.AncestorsOrSelf(1).First();
            var newsArchive = homePage.Children.FirstOrDefault(x => x.DocumentTypeAlias == "umbNewsOverview");
            if (newsArchive == null) return Enumerable.Empty<IPublishedContent>();

            return newsArchive.Children.Where(x => x.DocumentTypeAlias == "umbNewsItem")
                .OrderByDescending(x => x.Get<DateTime>("publishDate"))
                .ThenByDescending(x => x.CreateDate);
        }
    }
}
