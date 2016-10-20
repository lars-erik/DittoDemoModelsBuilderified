using System.Linq;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace DittoDemo.Ditto.Processors
{
    public class NewsArchiveLinkAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            var content = Value as UmbMaster;
            if (content == null) return null;

            return content.Home.FirstChild<UmbNewsOverview>();
        }
    }
}
