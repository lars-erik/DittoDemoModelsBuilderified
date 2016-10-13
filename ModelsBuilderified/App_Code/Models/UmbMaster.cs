using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace Umbraco.Web.PublishedContentModels
{
    public partial class UmbMaster : ILayout, IFeaturedSet, IAbout, ISocialLinks, ILatestNews
    {
        private UmbHomePage home = null;
        protected UmbHomePage Home
        {
            get
            {
                if (home == null)
                    home = this.AncestorOrSelf<UmbHomePage>();
                return home;
            }
        }

        string ILayout.SiteName
        {
            get { return Home.SiteName; }
        }

        string ILayout.Byline
        {
            get { return Home.Byline; }
        }

        string ILayout.Copyright
        {
            get { return Home.Copyright; }
        }

        public string DisplayTitle
        {
            get { return Title.IfNullOrWhiteSpace(Name); }
        }

        public virtual IEnumerable<UmbTextPage> FeaturedPages
        {
            get { return Home.FeaturedPages; }
        }

        UmbNewsOverview ILatestNews.Archive
        {
            get { return Home.Archive; }
        } 

        IEnumerable<UmbNewsItem> ILatestNews.LatestNewsItems
        {
            get { return Home.LatestNewsItems; }
        }

        string IAbout.AboutTitle
        {
            get { return Home.AboutTitle; }
        }

        IHtmlString IAbout.AboutText
        {
            get { return Home.AboutText; }
        }

        string ISocialLinks.FacebookLink
        {
            get { return Home.FacebookLink; }
        }

        string ISocialLinks.TwitterLink
        {
            get { return Home.TwitterLink; }
        }

        string ISocialLinks.RssLink
        {
            get { return Home.RssLink; }
        }

        string ISocialLinks.DribbbleLink
        {
            get { return Home.DribbbleLink; }
        }

        string ISocialLinks.LinkedInLink
        {
            get { return Home.LinkedInLink; }
        }

        string ISocialLinks.GoogleLink
        {
            get { return Home.GoogleLink; }
        }
    }
}