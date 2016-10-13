using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface ILayout : IPublishedContent
    {
        string SiteName { get; }
        string Byline { get; }
        string Copyright { get; }
        string DisplayTitle { get; }
    }
}