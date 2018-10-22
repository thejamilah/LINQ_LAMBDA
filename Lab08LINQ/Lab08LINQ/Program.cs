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

        static void JsonConversion()
        {
            string path = "../../../most_popular_quotes.json";
            string text = "";

            using (StreamReader sr = File.OpenText(path))
            {
                text = sr.ReadToEnd();
            }

            List<Quotes> theQuotes =JsonConvert.DeserializeObject<List<Quotes>>(text);

            IEnumerable<Quotes> allQuotes = theQuotes.Select(x => x);

            foreach (Quotes Quotes in theQuotes)
                
            {
                Console.WriteLine(theQuotes);
                //if (Quotes.AuthorQuotes == theQuotes)
                //{
                //    Console.WriteLine(theQuotes);
                //}
            }
        }

        //static void LinqManhatten()
        //{

        //}
    }
}
