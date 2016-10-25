using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace ModelsBuilderified.Models
{ 
    public partial class UmbTextPage
    {
        public IHtmlString Extract
        {
            get { return new HtmlString(BodyText.ToHtmlString().StripHtml().Truncate(100)); }
        }
    }
}