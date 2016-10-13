using System;
using System.Linq;
using DittoDemo.Models;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo.Ditto.Processors
{
    public class FeaturesAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as IPublishedContent;
            if (content == null) return Enumerable.Empty<NewsItemLink>();

            var homePage = content.AncestorOrSelf(1);
            return homePage.Children.Where(x => x.DocumentTypeAlias == "umbTextPage"
                && x.Get("featuredPage", defaultValue:false))
                .OrderBy(x => new Guid())
                .Take(4);
        }
    }
}
