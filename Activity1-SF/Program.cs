using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Activity1_SF
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string reversedNames;
            string[] names = new string[5];

            Console.WriteLine("Enter names: ");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }            

            //Duplicated Names Method
            Console.WriteLine("");
            
            int duplicateCount = DuplicatedNames(names);
            Console.WriteLine($"There are {duplicateCount} duplicated names");

            // Remove duplicates
            names = names.Distinct().ToArray();

            //Count Consonants Method
            Console.WriteLine("");
            foreach(string name in names)
            {
                int consonantCount = CountConsonants(name);
                Console.WriteLine($"There are {consonantCount} consonants characters in {name.ToLower()}.");
            }

            //Reverse Names Method
            Console.WriteLine("");           
            foreach (string name in names)
            {
                string reversedName = Reverse(name);
                Console.WriteLine($"The reverse of {name} is {reversedName}.");
            }

            //Ascending Names Method
            Console.WriteLine("");
            Console.WriteLine("Ascending: ");

            AscendStrings(names);
            
            foreach (string name in names)
            {
                reversedNames = Reverse(name);
                Console.WriteLine(reversedNames);
            }
            

            //Descending Names Method
            Console.WriteLine("");
            Console.WriteLine("Descending: ");

            DescendStrings(names);           
            
            foreach (string name in names)
            {
                reversedNames = Reverse(name);
                Console.WriteLine(reversedNames);
            }
            Console.ReadKey();
        }
        static int DuplicatedNames(string[] names)
        {
            int duplicatesCount = 0;

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {
                        duplicatesCount = duplicatesCount + 1;
                        duplicatesCount++;
                        break;
                    }
                }
            }

            return duplicatesCount;
        }       
        static int CountConsonants(string names)
        {
            int consonantCount = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in names) 
            {
                if(!vowels.Contains(c))
                {
                    consonantCount++;
                }
            }
            return consonantCount;
        }
        static string Reverse(string names)
        {
            
            char[] array = names.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
            
            
        }
        static void AscendStrings(string[] names)
        {
            int n = names.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(names[j], names[j + 1]) > 0)
                    {
                        // Swap arr[j] and arr[j+1]
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }
        static void DescendStrings(string[] names)
        {
            int n = names.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(names[j], names[j + 1]) < 0)
                    {
                        // Swap arr[j] and arr[j+1]
                        string temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
        }
    }
}
