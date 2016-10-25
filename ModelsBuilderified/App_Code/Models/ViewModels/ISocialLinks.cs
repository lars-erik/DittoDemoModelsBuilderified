using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface ISocialLinks
    {
        string FacebookLink { get; }
        string TwitterLink { get; }
        string RssLink { get; }
        string DribbbleLink { get; }
        string LinkedInLink { get; }
        string GoogleLink { get; }
    }
}