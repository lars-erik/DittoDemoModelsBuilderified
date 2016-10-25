using System.Collections.Generic;

namespace ModelsBuilderified.Models
{
    public interface IFeaturedSet
    {
        IEnumerable<UmbTextPage> FeaturedPages { get; }
    }
}