using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface IBanner : IPublishedContent
    {
        bool IsVisible { get; }
        string BackgroundImage { get; }
        string Header { get; }
        string Link { get; }
        string LinkText { get; }
        string Subheader { get; }
    }
}