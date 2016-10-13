using System.Linq;
using DittoDemo.Models;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace DittoDemo.Ditto.Processors
{
    public class MainNavAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as IPublishedContent;
            if (content == null) return Enumerable.Empty<NavLink>();

            var homePage = content.AncestorsOrSelf(1).First();
            return new[] { homePage }.Union(homePage.Children.Where(x => x.IsVisible()));
        }
    }
}