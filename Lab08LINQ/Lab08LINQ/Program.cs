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

            List<NewYork> theQuotes =JsonConvert.DeserializeObject<List<NewYork>>(text);

            IEnumerable<NewYork> allQuotes = theQuotes.Select(x => x);

            foreach (NewYork Quotes in theQuotes)
                
            {
                Console.WriteLine(Quotes.Author);
               
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
