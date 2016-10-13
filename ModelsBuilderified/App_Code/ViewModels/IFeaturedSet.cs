using System.Collections.Generic;

namespace Umbraco.Web.PublishedContentModels
{
    public interface IFeaturedSet
    {
        IEnumerable<UmbTextPage> FeaturedPages { get; }
    }
}