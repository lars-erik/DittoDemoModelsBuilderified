using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsBuilderified.Models
{

    public interface INewsArchive : ISiteContent
    {
        IEnumerable<INewsItem> News { get; }
    }

}