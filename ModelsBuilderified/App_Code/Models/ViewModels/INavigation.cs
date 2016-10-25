using System.Collections.Generic;
using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface INavigation
    {
        IEnumerable<INavigationContent> MenuItems { get; }
    }
}