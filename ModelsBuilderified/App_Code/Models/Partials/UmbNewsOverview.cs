using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsBuilderified.Models
{ 
    public partial class UmbNewsOverview : INewsArchive
    {
        public IEnumerable<INewsItem> News
        {
            get { return Children.OfType<INewsItem>(); }
        }
    }
}