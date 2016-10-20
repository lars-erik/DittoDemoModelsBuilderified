using Our.Umbraco.Ditto;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace DittoDemo.Ditto.Processors
{
    public class ExtractAttribute : DittoProcessorAttribute
    {
        public int Length { get; set; }

        public ExtractAttribute(int length = 100)
        {
            Length = length;
        }

        public override object ProcessValue()
        {
            var content = Value as IExtractable;
            if (content == null) return null;

            return content.Extract(Length);
        }
    }
}
