using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
           // Solution1();
             Solution2(); 

        }

        private static void Solution2()
        {
            char[] separators = ".,:;()[]\"\'\\/!? ".ToCharArray();

            string[] words = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> result = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                dict.Add(words[i], words[i].Length);
            }
            foreach (var item in dict)
            {
                if (item.Value < 5)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }

        private static void Solution1()
        {
            char[] delimiter = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            // char[] delimiter = ".,:;()[]\"\'\\/!? ".ToCharArray();
            string[] text = Console.ReadLine()
                .ToLower()
                .Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            text = text.Where(x => x.Length < 5).OrderBy(a => a).ToArray();
            text = text.Distinct().ToArray();

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
