using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.Web.PublishedContentModels
{
    /// <summary>
    /// Summary description for UmbHomePage
    /// </summary>
    public partial class UmbHomePage : IBanner
    {
        public bool BannerIsVisible
        {
            get { return !HideBanner; }
        }

        public override IEnumerable<UmbTextPage> FeaturedPages
        {
            get
            {
                return Children
                    .OfType<UmbTextPage>()
                    .Where(p => p.FeaturedPage);
            }
        }

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