using System;
using Our.Umbraco.Ditto;

namespace DittoDemo.Models
{
    public class NewsItemLink : Link
    {
        [UmbracoProperty("PublishDate", Order = 0),
            AltUmbracoProperty("CreateDate", Order = 1)]
        public DateTime Date { get; set; }
    }

}
