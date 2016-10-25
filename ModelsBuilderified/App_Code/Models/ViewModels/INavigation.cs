using System.Collections.Generic;
using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface INavigation : IPublishedContent
    {
        IEnumerable<ISiteContent> MenuItems { get; }
    }
}