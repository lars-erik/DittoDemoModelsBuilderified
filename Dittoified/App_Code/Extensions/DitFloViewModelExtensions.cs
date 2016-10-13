using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo
{
    public static class DitFloViewModelExtensions
    {
        public static IPublishedContent HomePage(this IDittoViewModel model)
        {
            return model.CurrentPage.AncestorOrSelf(1);
        }
    }
}
