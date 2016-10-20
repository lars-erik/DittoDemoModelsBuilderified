using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace Umbraco.Web.PublishedContentModels
{
    public static class ExtractableExtensions
    {
        public static string Extract(this IExtractable extractable, int length, bool addEllipsis = true)
        {
            return extractable.Content.ToHtmlString().StripHtml().Truncate(length, addEllipsis ? "..." : "");
        }
    }
}