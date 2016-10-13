using System.Web;
using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface IAbout : IPublishedContent
    {
        string AboutTitle { get; }
        IHtmlString AboutText { get; }
    }
}