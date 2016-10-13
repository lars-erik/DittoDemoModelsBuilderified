using System.Web;
using DittoDemo.Ditto.Processors;

namespace DittoDemo.ViewModels
{
    public class TextPageViewModel
    {
        [Title]
        public string Title { get; set; }

        public string Image { get; set; }

        public HtmlString BodyText { get; set; }
    }
}
