using System.Collections.Generic;
using DittoDemo.Ditto.Processors;
using DittoDemo.Models;

namespace DittoDemo.ViewModels
{
    public class TopNavigationViewModel
    {
        [MainNav]
        public IEnumerable<NavLink> MenuItems { get; set; }
    }
}