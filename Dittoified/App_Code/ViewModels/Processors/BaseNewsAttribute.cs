using System;
using System.Collections.Generic;
using System.Linq;
using Our.Umbraco.Ditto;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.PublishedContentModels;

namespace DittoDemo.Ditto.Processors
{
    public abstract class BaseNewsAttribute : DittoProcessorAttribute
    {
        protected IEnumerable<UmbNewsItem> GetNews()
        {
            var content = Value as UmbMaster;
            if (content == null) return Enumerable.Empty<UmbNewsItem>();

            var newsArchive = content.Home.FirstChild<UmbNewsOverview>();
            if (newsArchive == null) return Enumerable.Empty<UmbNewsItem>();

            return newsArchive.Children<UmbNewsItem>()
                .OrderByDescending(x => x.PublishDate)
                .ThenByDescending(x => x.CreateDate);
        }
    }
}
