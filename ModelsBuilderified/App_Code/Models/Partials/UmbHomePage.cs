using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;

namespace ModelsBuilderified.Models
{
    /// <summary>
    /// Summary description for UmbHomePage
    /// </summary>
    public partial class UmbHomePage : 
        ILayout, 
        IFeaturedSet, 
        ISocialLinks, 
        ILatestNews, 
        IBanner
    {
        /*
         * LAYOUT
         */ 
        string ILayout.SiteUrl { get { return Url; } }

        /* 
         * ABOUT 
         */
        string IAbout.Title { get { return AboutTitle; } }
        IHtmlString IAbout.Text { get { return AboutText; } }

        /*
         * BANNER
         */

        bool IBanner.IsVisible { get { return !HideBanner; } }
        string IBanner.BackgroundImage { get { return (BannerBackgroundImage ?? "").ToString(); } }
        string IBanner.Header { get { return BannerHeader;} }
        string IBanner.Link { get { return BannerLink.Url; } }
        string IBanner.LinkText { get { return BannerLinkText; } }
        string IBanner.Subheader { get { return BannerSubheader; } }

        /*
         * FEATURES
         */

        public IEnumerable<UmbTextPage> FeaturedPages
        {
            get
            {
                return Children
                    .OfType<UmbTextPage>()
                    .Where(p => p.FeaturedPage);
            }
        }

        /*
         * NEWS
         */

        public INewsArchive Archive
        {
            get { return Children.OfType<UmbNewsOverview>().First(); }
        }

        public IEnumerable<INewsItem> LatestNewsItems
        {
            get
            {
                return Archive
                    .News
                    .OrderByDescending(n => n.DisplayDate)
                    .Take(5);
            }
        }

        public INewsItem FeaturedNewsItem
        {
            get { return LatestNewsItems.First(); }
        }
    }
}