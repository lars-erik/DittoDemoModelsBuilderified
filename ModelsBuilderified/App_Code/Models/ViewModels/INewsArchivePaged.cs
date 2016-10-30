using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface INewsArchivePaged : ISiteContent, IPublishedContent
    {
        IEnumerable<INewsItem> NewsPage { get; set; }
        PageModel PageModel { get; set; }
    } 
}