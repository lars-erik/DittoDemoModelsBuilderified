using System.Collections.Generic;

namespace ModelsBuilderified.Models
{
    public interface ILatestNews
    {
        INewsArchive Archive { get; }
        IEnumerable<INewsItem> LatestNewsItems { get; }
        INewsItem FeaturedNewsItem { get; }
    }
}