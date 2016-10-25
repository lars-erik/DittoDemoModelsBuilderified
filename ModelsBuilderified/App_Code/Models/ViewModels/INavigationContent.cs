using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsBuilderified.Models
{
    public interface INavigationContent
    {
        string Name { get; }

        string Url { get; }

        bool IsActive { get; }

        bool IsVisible { get; }

        string Target { get; }
    }

}