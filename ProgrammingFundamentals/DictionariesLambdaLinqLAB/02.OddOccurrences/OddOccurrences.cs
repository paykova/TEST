using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> pieces = new Dictionary<string, int>();
            List<string> odd = new List<string>(); 

            for (int i = 0; i < words.Length; i++)
            {
                if (pieces.ContainsKey(words[i]))
                {
                    pieces[words[i]]++;
                }
                else
                {
                    pieces[words[i]] = 1; 
                }
            }
            foreach (var item in pieces)
            {
                if (item.Value %2 != 0)
                {
                    odd.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", odd));
        }
    }
}
