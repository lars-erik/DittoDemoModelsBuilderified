using System.Linq;
using Our.Umbraco.Ditto;

namespace DittoDemo.Ditto.Processors
{
    public class LatestNewsAttribute : BaseNewsAttribute
    {
        public override object ProcessValue()
        {
            return GetNews().Take(5);
        }
    }
}
