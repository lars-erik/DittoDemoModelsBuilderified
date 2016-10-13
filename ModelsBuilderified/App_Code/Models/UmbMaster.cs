using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace Umbraco.Web.PublishedContentModels
{
    public partial class UmbMaster : ISiteContent, INavigation
    {
        private UmbHomePage home = null;

        public UmbHomePage Home
        {
            get
            {
                if (home == null)
                    home = this.AncestorOrSelf<UmbHomePage>();
                return home;
            }
        }

        public string DisplayTitle
        {
            get { return Title.IfNullOrWhiteSpace(Name); }
        }

        IEnumerable<ISiteContent> INavigation.MenuItems
        {
            get { return home.MenuItems; }
        }
    }
}