using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface ILayout : INavigation, IAbout
    {
        string SiteName { get; }
        string SiteUrl { get; }
        string Byline { get; }
        string Copyright { get; }
        string DisplayTitle { get; }
    }
}