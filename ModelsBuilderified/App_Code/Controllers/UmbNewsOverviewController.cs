using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsBuilderified.Models;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace ModelsBuilderified.Controllers
{
    public class UmbNewsOverviewController : RenderMvcController
    {
        public ActionResult Index(RenderModel<UmbNewsOverview> model, long p = 1)
        {
            var pageModel = new PageModel
            {
                PageSize = 2,
                CurrentPage = p,
                TotalItems = model.Content.News.Count()
            };

            pageModel.TotalPages = (long) Math.Ceiling(pageModel.TotalItems/(decimal) pageModel.PageSize);
            pageModel.CurrentPage = Math.Max(1, Math.Min(pageModel.CurrentPage, pageModel.TotalPages));

            model.Content.NewsPage = model.Content.News
                .Skip((int) (pageModel.CurrentPage - 1)*pageModel.PageSize)
                .Take(pageModel.PageSize);

            model.Content.PageModel = pageModel;

            return base.Index(model);
        }
    }
}