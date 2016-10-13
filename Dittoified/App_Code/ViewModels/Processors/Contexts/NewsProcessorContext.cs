using Our.Umbraco.Ditto;

namespace DittoDemo.Ditto.Processors.Contexts
{
    public class NewsProcessorContext : DittoProcessorContext
    {
        public long CurrentPage { get; set; }
    }
}
