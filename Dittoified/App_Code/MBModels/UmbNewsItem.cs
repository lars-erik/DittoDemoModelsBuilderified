using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.Web.PublishedContentModels
{ 

    /// <summary>
    /// Summary description for UmbNewsItem
    /// </summary>
    public partial class UmbNewsItem : IExtractable
    {
        IHtmlString IExtractable.Content { get { return BodyText; } }
    }

}