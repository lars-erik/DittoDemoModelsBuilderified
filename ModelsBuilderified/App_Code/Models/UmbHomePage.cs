using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.Web.PublishedContentModels
{
    /// <summary>
    /// Summary description for UmbHomePage
    /// </summary>
    public partial class UmbHomePage : 
        ILayout, 
        IFeaturedSet, 
        IAbout, 
        ISocialLinks, 
        ILatestNews, 
        IBanner
    {
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
         * NAVIGATION
         */

        public IEnumerable<ISiteContent> MenuItems
        {
            get
            {
                return new[] {this}
                    .Union(
                        Children
                        .OfType<ISiteContent>()
                        .Where(c => c.IsVisible())
                    );
            }
        } 

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

        public UmbNewsOverview Archive
        {
            get { return Children.OfType<UmbNewsOverview>().First(); }
        }

        public IEnumerable<UmbNewsItem> LatestNewsItems
        {
            get
            {
                return Archive
                    .Children<UmbNewsItem>()
                    .OrderByDescending(n => n.DisplayDate)
                    .Take(5);
            }
        }

        public UmbNewsItem FeaturedNewsItem
        {
            get { return LatestNewsItems.First(); }
        }
    }
}