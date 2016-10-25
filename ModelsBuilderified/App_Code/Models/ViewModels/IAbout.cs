using System.Web;
using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface IAbout
    {
        string Title { get; }
        IHtmlString Text { get; }
    }
}