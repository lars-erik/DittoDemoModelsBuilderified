using DittoDemo.Ditto.Processors;
using DittoDemo.Models;
using Our.Umbraco.Ditto;

namespace DittoDemo.ViewModels
{
    public class FeaturedNewsViewModel
    {
        [FeaturedNews]
        public NewsPreviewLink FeaturedNews { get; set; }

        [NewsArchiveLink]
        public Link Archive { get; set; }
    }
}
