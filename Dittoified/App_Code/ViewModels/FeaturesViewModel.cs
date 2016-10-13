using System.Collections.Generic;
using DittoDemo.Ditto.Processors;
using DittoDemo.Models;

namespace DittoDemo.ViewModels
{
    public class FeaturesViewModel
    {
        [Features]
        public IEnumerable<FeatureLink> FeatureItems { get; set; }
    }
}
