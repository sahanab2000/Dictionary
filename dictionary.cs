using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doDictionaryDemo();
        }
        public static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Ishani");
            dictionary.Add(101, "krithi");
            dictionary.Add(102, "Aman");

            Console.WriteLine("Access value using key(key=100): " + dictionary [102]);

            Console.WriteLine("\nIterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + " & Value =" +element.Value);
            }
        }
    }
}