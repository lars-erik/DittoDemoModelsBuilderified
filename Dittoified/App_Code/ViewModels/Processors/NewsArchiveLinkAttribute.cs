using System.Linq;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo.Ditto.Processors
{
    public class NewsArchiveLinkAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as IPublishedContent;
            if (content == null) return null;

            var homePage = content.AncestorOrSelf(1);
            return homePage.Children.FirstOrDefault(x => x.DocumentTypeAlias == "umbNewsOverview");
        }
    }
}
