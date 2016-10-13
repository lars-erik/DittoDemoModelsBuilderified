using System.Linq;

namespace DittoDemo.Ditto.Processors
{
    public class FeaturedNewsAttribute : BaseNewsAttribute
    {
        public override object ProcessValue()
        {
            return GetNews().First();
        }
    }
}
