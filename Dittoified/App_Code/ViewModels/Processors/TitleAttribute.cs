using System.Linq;
using Our.Umbraco.Ditto;

namespace DittoDemo.Ditto.Processors
{
    public class TitleAttribute : DittoMultiProcessorAttribute
    {
        public string TitleAttr { get; set; }

        public TitleAttribute()
            : base(Enumerable.Empty<DittoProcessorAttribute>())
        {
            base.Attributes.AddRange(new[] {
                new UmbracoPropertyAttribute(TitleAttr),
                new AltUmbracoPropertyAttribute("Name")
            });
        }
    }
}
