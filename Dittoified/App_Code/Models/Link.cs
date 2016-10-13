using DittoDemo.Ditto.Processors;
using Our.Umbraco.Ditto;

namespace DittoDemo.Models
{
    public class Link
    {
        [UmbracoProperty("Name", Order = 0)]
        public string Title { get; set; }
        
        public string Url { get; set; }

        [UrlTarget]
        public string UrlTarget { get; set; }
    }
}
