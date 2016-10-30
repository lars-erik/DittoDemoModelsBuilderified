using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface ISiteContent
    {
        ILayout Layout { get; }

        string DisplayTitle { get; }

        string Url { get; }
    }
}