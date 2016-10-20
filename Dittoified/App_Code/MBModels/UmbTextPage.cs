using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.Web.PublishedContentModels
{ 
    public partial class UmbTextPage : IExtractable
    {
        IHtmlString IExtractable.Content { get { return BodyText; } }
    }
}