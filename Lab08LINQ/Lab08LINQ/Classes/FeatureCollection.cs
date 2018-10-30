using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
