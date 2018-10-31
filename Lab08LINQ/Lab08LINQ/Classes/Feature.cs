using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08LINQ.Classes
{
    public class Feature
    {   
        [JsonProperty("Type")]
        public string type { get; set; }

        [JsonProperty("Properties")]
        public Properties Properties { get; set; }
    }

}
