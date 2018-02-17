using System;
using System.Linq;

namespace _06.FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var k = num.Length / 4;

            var row11 = num.Take(k).Reverse();
            var row12 = num.Reverse().Take(k);
            var row2 = num.Skip(k).Take(2 * k).ToArray(); 
            var firstRow = row11.Concat(row12).ToArray();
            var sum = firstRow.Select((x, index) => x + row2[index]);
      
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
