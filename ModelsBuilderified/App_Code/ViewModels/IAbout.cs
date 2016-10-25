using System.Web;
using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface IAbout
    {
        string Title { get; }
        IHtmlString Text { get; }
    }
}