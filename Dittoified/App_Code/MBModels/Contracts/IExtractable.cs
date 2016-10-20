using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umbraco.Web.PublishedContentModels
{ 

    public interface IExtractable
    {
        IHtmlString Content { get; }
    }

}