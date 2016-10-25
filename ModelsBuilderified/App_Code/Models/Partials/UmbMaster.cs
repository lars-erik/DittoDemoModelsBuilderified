using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Web;

namespace ModelsBuilderified.Models
{
    public partial class UmbMaster : ISiteContent, INavigationContent
    {
        private ILayout layout = null;

        public ILayout Layout
        {
            get
            {
                if (layout == null)
                    layout = this.AncestorOrSelf<UmbHomePage>();
                return layout;
            }
        }

        public string DisplayTitle
        {
            get { return Title.IfNullOrWhiteSpace(Name); }
        }

        public bool IsVisible
        {
            get { return this.IsVisible(); }
        }

        bool INavigationContent.IsActive
        {
            get { return UmbracoContext.Current.PageId == Id; }
        }

        string INavigationContent.Target
        {
            get { return Url.StartsWith("/") ? "_top" : "_blank"; }
        }
    }
}