using Our.Umbraco.Ditto;

namespace DittoDemo.Ditto.Processors
{
    [DittoProcessorMetaData(ValueType = typeof(bool))]
    public class InvertBooleanAttribute : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            return !((bool)Value);
        }
    }
}
