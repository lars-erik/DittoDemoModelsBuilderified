using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface IBanner : IPublishedContent
    {
        bool BannerIsVisible { get; }
        object BannerBackgroundImage { get; }
        string BannerHeader { get; }
        IPublishedContent BannerLink { get; }
        string BannerLinkText { get; }
        string BannerSubheader { get; }
    }
}