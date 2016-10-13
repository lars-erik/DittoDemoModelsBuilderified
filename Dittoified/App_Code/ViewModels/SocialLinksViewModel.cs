using Our.Umbraco.Ditto;

namespace DittoDemo.ViewModels
{
    [UmbracoProperties(Recursive = true)]
    public class SocialLinksViewModel
    {
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string RssLink { get; set; }
        public string DribbbleLink { get; set; }
        public string LinkedinLink { get; set; }
        public string GoogleLink { get; set; }
    }
}
