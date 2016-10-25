using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface ISiteContent : IPublishedContent
    {
        UmbHomePage Home { get; }

        string DisplayTitle { get; }
    }
}