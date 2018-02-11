using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine().Split(new char[] {',', ' ', ';', ':',
            '.', '!', '(', ')', '"', '\'', '\\',  '/', '[', ']'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixed = new List<string>();
            int small = 0;
            int big = 0;
            int other = 0;


            for (int i = 0; i < words.Count; i++)
            {
                small = 0;
                big = 0;
                other = 0;

                foreach (var ch in words[i])
                {
                    if (ch > 64 && ch < 91)
                    {
                        big++;
                    }
                    else if (ch > 96 && ch < 123)
                    {
                        small++;
                    }
                    else
                    {
                        other++;
                    }
                }
                if (small != 0 && big == 0 && other == 0)
                {
                    lowerCase.Add(words[i]);
                }
                else if (big != 0 && small == 0 && other ==0)
                {
                    upperCase.Add(words[i]);
                }
                else
                {
                    mixed.Add(words[i]);
                }
            }
            Console.Write("Lower-case: ");
            Console.Write(string.Join(", ", lowerCase));
            Console.WriteLine();
            Console.Write("Mixed-case: ");
            Console.Write(string.Join(", ", mixed));
            Console.WriteLine();
            Console.Write("Upper-case: ");
            Console.Write(string.Join(", ", upperCase));
            Console.WriteLine();
        }

    }
}
