using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08LINQ.Classes
{
    public class NewYork
    {

        [JsonProperty("Likes")]
        public string Likes { get; set; }

        [JsonProperty("Author")]
        public string Author { get; set; }
        public List<NewYork> AuthorQuotes { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }


    }
}
