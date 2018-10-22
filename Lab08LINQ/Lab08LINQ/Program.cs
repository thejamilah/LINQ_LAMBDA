using Lab08LINQ.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab08LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ in Manhatten");
            Console.WriteLine("==========");
            JsonConvert();
        }

        static void JsonConvert()
        {
            string path = "../../../most_popular_quotes.json";
            string text = "";

            using (StreamReader sr = FileStyleUriParser.OpenText(path))
            {
                text = sr.ReadToEnd();
            }

            List<Quotes> theQuotes = JsonConvert.DeserializeObject<List<Quotes>>(text);
        }

        static void LinqManhatten()
        {

        }
    }
}
