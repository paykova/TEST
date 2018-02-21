using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 0;

            int index = text.IndexOf(pattern);
          
            while (index >= 0)
            {
                count++;
                index = text.IndexOf(pattern,index +1);
            }
            Console.WriteLine(count);
        }
    }
}
