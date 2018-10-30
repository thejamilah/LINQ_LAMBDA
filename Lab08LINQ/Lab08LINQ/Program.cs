using Lab08LINQ.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Lab08LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ in Manhatten");
            Console.WriteLine("==========");
            JsonConversion();
        }

        public static void JsonConversion()
        {
            string path = "../../../data.json";
            string text = "";

            using (StreamReader sr = File.OpenText(path))
            {
                text = sr.ReadToEnd();
            }

            var Data = JsonConvert.DeserializeObject<FeatureCollection>(text);

            //All neighborhoods with duplicates and empty lines
            //Of the Lab assignment this satifies Query 1. Output all of the neighborhoods in this data list
            var allNeighborhood = Data.Features.Select(x => x).Select(x => x.Properties).Select(x => x.neighborhood);

            foreach (var item in allNeighborhood)
            {
                Console.WriteLine(item);
            }
            //Separation between next query
            Console.WriteLine("====================");
        }

    }
}
