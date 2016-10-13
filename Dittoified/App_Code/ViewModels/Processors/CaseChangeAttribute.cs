using System.Collections.Generic;
using System.Linq;
using Our.Umbraco.Ditto;

public class CaseChangeAttribute : DittoProcessorAttribute
{
    public Case Case { get; set; }

    public CaseChangeAttribute(Case case1)
    {
        Case = case1;
    }

    public override object ProcessValue()
    {
        var strVal = Value.ToString();
        return (Case == Case.Lowercase) ? strVal.ToLower() : strVal.ToUpper();
    }
}

public enum Case
{
    Uppercase,
    Lowercase
}

public class LowercaseUrlAttribute : DittoMultiProcessorAttribute
{
    public Case Case { get; set; }

    public LowercaseUrlAttribute() 
        : base(Enumerable.Empty<DittoProcessorAttribute>())
    {
        base.Attributes.AddRange(this.GetProcessors());
    }

    private IEnumerable<DittoProcessorAttribute> GetProcessors()
    {
        return new DittoProcessorAttribute[] {
            new UmbracoPropertyAttribute("Url"),
            new CaseChangeAttribute(this.Case)
        };
    }
}