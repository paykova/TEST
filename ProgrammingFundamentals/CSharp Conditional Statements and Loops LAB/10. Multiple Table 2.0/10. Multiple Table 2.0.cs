using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiple_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var sum = 1;

            if ((m >= 1) && (m <= 10))
            {
                for (int i = m; i <= 10; i++)
                {
                    sum = n * i;
                    Console.WriteLine($"{n} X {i} = {sum}");
                }
            }
            else
            {
                sum = n * m;
                Console.WriteLine($"{n} X {m} = {sum}");
            }
           
        }
    }
}
