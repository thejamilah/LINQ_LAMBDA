using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08LINQ.Classes
{
    public class Quotes
    {
        [JsonProperty("Author")]
        public string Author { get; set; }
    }
}
