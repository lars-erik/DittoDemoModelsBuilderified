using System.Web;
using DittoDemo.Ditto.Processors;
using Our.Umbraco.Ditto;

namespace DittoDemo.Models
{
    public class NewsPreviewLink : NewsItemLink
    {
        [UmbracoProperty("SubHeader")]
        public string SubTitle { get; set; }

        public string Image { get; set; }

        [Extract(200)]
        public HtmlString Extract { get; set; }
    }

}
