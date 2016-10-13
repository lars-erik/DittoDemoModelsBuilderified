using DittoDemo.Ditto.Processors;
using DittoDemo.Models;
using Our.Umbraco.Ditto;

namespace DittoDemo.ViewModels
{
    [UmbracoProperties(Recursive = true)]
    public class LayoutViewModel
    {
        public string SiteName { get; set; }

        public string Byline { get; set; }

        public string Copyright { get; set; }

        [HomeLink]
        public Link HomeLink { get; set; }
    }
}
