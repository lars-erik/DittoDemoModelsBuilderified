using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Web;

namespace ModelsBuilderified.Models
{
    public partial class UmbMaster : ISiteContent
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

    }
}