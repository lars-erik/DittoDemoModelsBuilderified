using System.Collections.Generic;

namespace ModelsBuilderified.Models
{
    public interface ILatestNews
    {
        UmbNewsOverview Archive { get; }
        IEnumerable<UmbNewsItem> LatestNewsItems { get; }
    }
}