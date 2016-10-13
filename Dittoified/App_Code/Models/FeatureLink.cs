using System.Web;
using DittoDemo.Ditto.Processors;

namespace DittoDemo.Models
{
    public class FeatureLink : Link
    {
        public string Image { get; set; }

        [Extract]
        public HtmlString Extract { get; set; }
    }
}