using DittoDemo.Ditto.Processors;

namespace DittoDemo.Models
{
    public class NavLink : Link
    {
        [ActiveNavLink]
        public bool IsActive { get; set; }
    }
}
