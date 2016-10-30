using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace ModelsBuilderified.Models
{
    public partial class UmbNewsItem : INewsItem
    {
        public DateTime DisplayDate
        {
            get
            {
                if (PublishDate == default(DateTime))
                    return CreateDate;
                return PublishDate;
            }
        }
        public IHtmlString Extract
        {
            get { return new HtmlString(BodyText.ToHtmlString().StripHtml().Truncate(200)); }
        }

    }
}