using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo.Ditto.Processors
{
    public class HomeLinkAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as IPublishedContent;
            if (content == null) return null;

            return content.AncestorOrSelf(1);
        }
    }
}
