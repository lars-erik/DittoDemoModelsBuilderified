using Umbraco.Core.Models;

namespace ModelsBuilderified.Models
{
    public interface IBanner
    {
        bool IsVisible { get; }
        string BackgroundImage { get; }
        string Header { get; }
        string Link { get; }
        string LinkText { get; }
        string Subheader { get; }
    }
}