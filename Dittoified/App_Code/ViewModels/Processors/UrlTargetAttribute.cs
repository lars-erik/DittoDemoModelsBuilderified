using Our.Umbraco.Ditto;
using Umbraco.Core.Models;

namespace DittoDemo.Ditto.Processors
{
    public class UrlTargetAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as IPublishedContent;
            if (content == null) return null;

            return content.Url.StartsWith("/") ? "_self" : "_blank";
        }
    }
}
