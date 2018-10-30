using Lab08LINQ.Classes;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Lab08LINQ
{
    public class Program
    {
        public static void Main(string[] args)
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
            Console.WriteLine(" ");
            Console.WriteLine("====================");
            Console.WriteLine(" ");

            //All neighborhoods; do not print empty lines
            //Of the Lab assignment this satifies Query 2. Filter out all the neighborhoods that do not have any names
            var removeEmptyNeighborhood = allNeighborhood.Where(x => x != "");

            foreach (var item in removeEmptyNeighborhood)
            {
                Console.WriteLine(item);
            }

            //Separation between next query
            Console.WriteLine(" ");
            Console.WriteLine("===================");
            Console.WriteLine(" ");

            //Remove neighborhood using .Distint() reference https://www.dotnetperls.com/distinct for future reference
            //Of the Lab assignment this satifies Query 3. Remove the Duplicates
            var distinctNeighborhood = removeEmptyNeighborhood.Distinct();

            foreach (var item in distinctNeighborhood)
            {
                Console.WriteLine(item);
            }

            //Separation between next query
            Console.WriteLine(" ");
            Console.WriteLine("===================");
            Console.WriteLine(" ");

            //Consolidate 
            //Of the Lab assignment this satifies Query 4. Rewrite the queries from above, and consolidate all into one single query.
            var consolidateData = Data.Features.Select(x => x)
                                               .Select(x => x.Properties.neighborhood)
                                               .Where(x => x != "")
                                               .Distinct();

            foreach (var item in consolidateData)
            {
                Console.WriteLine(item);
            }

            //Separation between next query
            Console.WriteLine(" ");
            Console.WriteLine("====================");
            Console.WriteLine(" ");

            //Use LINQ instead of Lamda => expressions
            //Of the Lab assignment this satifies 5. Rewrite at least one of these questions only using the opposing method (example: Use LINQ instead of a Lambda and vice versa.)
            //Object reference is required
        }

        static void LinqQuery()
        {
            var useLinq = from Properties in neighborhood

                          
        }
    }
}
