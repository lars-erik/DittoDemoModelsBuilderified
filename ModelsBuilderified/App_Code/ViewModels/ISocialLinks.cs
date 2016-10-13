using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface ISocialLinks : IPublishedContent
    {
        string FacebookLink { get; }
        string TwitterLink { get; }
        string RssLink { get; }
        string DribbbleLink { get; }
        string LinkedInLink { get; }
        string GoogleLink { get; }
    }
}