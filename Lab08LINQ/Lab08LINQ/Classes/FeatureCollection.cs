using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lab08LINQ.Classes
{
    public class FeatureCollection
    {

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Features")]
        public List<Feature> Features { get; set; }

    }
}
