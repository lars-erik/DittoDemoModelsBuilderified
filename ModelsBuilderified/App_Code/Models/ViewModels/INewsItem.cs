using System;
using System.Web;

namespace ModelsBuilderified.Models
{
    public interface INewsItem
    {
        string DisplayTitle { get; }
        string Subheader { get; }
        DateTime DisplayDate { get; }
        string Image { get; }
        IHtmlString Extract { get; }
        string Url { get; }
    }
}