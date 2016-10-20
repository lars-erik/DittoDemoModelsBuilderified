using System.Linq;
using DittoDemo.Models;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace DittoDemo.Ditto.Processors
{
    public class MainNavAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as UmbMaster;
            if (content == null) return Enumerable.Empty<NavLink>();

            return new[] { content.Home }.Union(content.Home.Children.Where(x => x.IsVisible()));
        }
    }
}