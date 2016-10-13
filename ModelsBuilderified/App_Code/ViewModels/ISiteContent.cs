using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface ISiteContent : IPublishedContent
    {
        UmbHomePage Home { get; }

        string DisplayTitle { get; }
    }
}