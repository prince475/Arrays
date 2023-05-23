
using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"<name>", "Ana", "Julie"};


            names.Add("Peter");
            names.Add("Jane");
            names.Remove("Julie");
            names.Remove("<name>");
            names.Remove("Ana");

            names.Sort(); // performs a default sort for instance here it will sort according Alphabetically

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()!}");
            }

            // we can also do it the following way

            // for (int i =0; i < names.Count; i++)
            // {
            //     Console.WriteLine($"Hello {names[i].ToUpper()!}");
            // }

            var index = names.IndexOf("Julie");
            // Console.WriteLine($"Found Jane at {index}");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns{index}");
            }
            else
            {
                Console.WriteLine($"The {names[index]} is at index {index}");
            }
        }
    }
}
