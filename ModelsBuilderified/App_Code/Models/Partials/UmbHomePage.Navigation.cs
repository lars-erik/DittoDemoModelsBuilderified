using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsBuilderified.Models
{
    public partial class UmbHomePage
    {
        IEnumerable<INavigationContent> INavigation.MenuItems
        {
            get
            {
                return new[] { this }
                    .Union(
                        Children
                        .OfType<INavigationContent>()
                        .Where(c => c.IsVisible)
                    );
            }
        }
    }
}