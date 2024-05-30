using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();

            //Call the reverse string and print the result
            string reverString = ReverseString(userInput);
            Console.WriteLine("Reversed String: {0}", reverString);

            Console.WriteLine("Enter a search string: ");
            string searchString = Console.ReadLine();
            int occurrences = CountOccurrences(userInput, searchString);
            Console.WriteLine("Number of occurrence: {0}", occurrences);

            Console.WriteLine("Enter an old substring and a new substring: ");
            string oldSubstring = Console.ReadLine();
            string newSubstring = Console.ReadLine();
            string modifyString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine("New string: {0}", modifyString);

            Console.WriteLine("Remove all space! ");
            modifyString = RemoveWhitespace(userInput);
            Console.WriteLine("New string: {0}", modifyString);

            Console.WriteLine("Press Enter !");
            Console.ReadLine();
        }
        public static string ReverseString(string inputString)
        {
            if (inputString == null)
            {
                return null;
            }

            return string.Join("", inputString.Reverse());
        }

        public static int CountOccurrences(string inputString, string searchString)
        {
            if (inputString == null || searchString == null || searchString.Length == 0)
            {
                return 0;
            }

            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(searchString, index)) != -1)
            {
                count++;
                index += searchString.Length;
            }

            return count;
        }

        public static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            if (inputString == null)
            {
                return null;
            }

            // Use String.Replace to replace occurrences
            return inputString.Replace(oldSubstring, newSubstring);
        }

        public static string RemoveWhitespace(string inputString)
        {
            if (inputString == null)
            {
                return null;
            }

            return Regex.Replace(inputString, @"\s", "");
        }


    }
}
