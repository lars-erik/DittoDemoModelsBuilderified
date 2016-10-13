using System.Web;
using DittoDemo.Ditto.Processors;

namespace DittoDemo.ViewModels
{
    public class NewsItemViewModel
    {
        [Title]
        public string Title { get; set; }

        public string Image { get; set; }

        public HtmlString BodyText { get; set; }
    }
}
