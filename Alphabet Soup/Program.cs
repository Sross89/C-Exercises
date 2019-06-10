using System;
using System.Linq;

// Basic program to scramble input strings
namespace Alphabet_Soup
{
    class Program
    {
        public static string AlphabeticalSort(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }

        public static string AlphabeticalSortBackwards(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            Array.Reverse(characters);
            return new string(characters);
        }

        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter String: ");
            input = Console.ReadLine();
            while (input != "0")
            {
                Console.WriteLine("Sort: " + AlphabeticalSort(input));
                Console.WriteLine("Sort Backwards: " + AlphabeticalSortBackwards(input));
                Console.Write("\nEnter String: ");
                input = Console.ReadLine();
            }
        }
    }
}
