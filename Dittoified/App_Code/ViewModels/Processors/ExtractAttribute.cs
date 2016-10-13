using Our.Umbraco.Ditto;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo.Ditto.Processors
{
    public class ExtractAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as IPublishedContent;
            if (content == null) return null;

            if (content.HasValue("extract")) return content.Get<string>("extract");
            if (content.HasValue("bodyText")) return content.Get<string>("bodyText").StripHtml().Truncate(100);
            return null;
        }
    }
}
