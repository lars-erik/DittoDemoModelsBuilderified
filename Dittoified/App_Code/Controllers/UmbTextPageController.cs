using System.Web.Mvc;
using DittoDemo.ViewModels;
using Our.Umbraco.Ditto;
using Umbraco.Web.Models;

namespace DittoDemo.Controllers
{
    public class UmbTextPageController : DittoController
    {
        public ActionResult Index(RenderModel model, long p = 1)
        {
            var typedModel = model.Content.As<TextPageViewModel>();
            typedModel.Title = "[Overwritten] " + typedModel.Title; 

            return CurrentView(typedModel);
        }
    }

}
