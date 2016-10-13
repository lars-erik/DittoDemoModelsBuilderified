using System.Collections.Generic;

namespace Umbraco.Web.PublishedContentModels
{
    public interface ILatestNews
    {
        UmbNewsOverview Archive { get; }
        IEnumerable<UmbNewsItem> LatestNewsItems { get; }
    }
}