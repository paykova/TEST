using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            //  Solution1();
            Solution2();

        }

        private static void Solution2()
        {
            char[] separators = ".,:;()[]\"\'\\/!? ".ToCharArray();

            string[] words = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] distinctWords = words.Distinct().OrderBy(w => w).ToArray();
         //   Console.WriteLine(string.Join(", ", distinctWords));

            Dictionary<string, int> some = new Dictionary<string, int>();
            List<string> result = new List<string>();

            for (int i = 0; i < distinctWords.Length; i++)
            {
                some.Add(distinctWords[i], distinctWords[i].Length);
            }
            foreach (var item in some)
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
