using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Umbraco.Web.PublishedContentModels
{
    public interface INavigation : IPublishedContent
    {
        IEnumerable<ISiteContent> MenuItems { get; }
    }
}