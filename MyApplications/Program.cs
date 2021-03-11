using System;
using System.Collections;

namespace MyApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashtablbasic();
           // SortedListBasic();

        }

        private static void SortedListBasic()
        {
            var veriable = new SortedList()
            {
                {"variables",5 },
                {"Loops",15 },
                {"operators",25 },
                {"decisions",40 },
                {"conditions",60 },
                {"Classes",150 },

            };
            Console.WriteLine($"{"Konular",10}{"Sayfalar",33}");
            foreach (DictionaryEntry item in veriable)
            {
                Console.WriteLine($"{item.Key,10} {item.Value,33}");
            }
        }

        /// <summary>
        /// Hashtablosuyla value - key örneği yaptık
        /// </summary>
        private static void Hashtablbasic()
        {

            //HashTable uygulaması

            string hood;
            Console.WriteLine("Please enter a title??");
            hood = Console.ReadLine();

            hood = hood.ToLower();
            var CharacterSet = new Hashtable()
            {
                {'\'','-' },
                {'ş','s' },
                {'ö','o' },
                {'ü','u' },
                {'ğ','g' },
                {'ı','i' },
                {'?','-' },
                {'!','-' },
                {'$','_' },
                {'ç','c' },
                {'*','_' },
                {' ','-' },


            };
            foreach (DictionaryEntry item in CharacterSet)
            {
                hood = hood.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(hood);
        }

    }
}
