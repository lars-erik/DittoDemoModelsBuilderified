using System;
using System.Linq;
using DittoDemo.Models;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace DittoDemo.Ditto.Processors
{
    public class FeaturesAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as UmbMaster;
            if (content == null) return Enumerable.Empty<UmbTextPage>();

            return content.Home.Children<UmbTextPage>()
                .Where(x => x.FeaturedPage)
                .OrderBy(x => new Guid())
                .Take(4);
        }
    }
}
