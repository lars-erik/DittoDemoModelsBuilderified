using DittoDemo.Ditto.Processors.Contexts;
using Our.Umbraco.Ditto;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace DittoDemo.Controllers
{
    public class UmbNewsOverviewController : DittoController
    {
        public ActionResult Index(RenderModel model, long p = 1)
        {
            RegisterProcessorContext(new NewsProcessorContext
            {
                CurrentPage = p
            });

            return CurrentView(model);
        }
    }

}
