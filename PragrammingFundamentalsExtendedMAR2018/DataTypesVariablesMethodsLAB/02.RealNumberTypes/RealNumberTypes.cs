using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RealNumberTypes
{
    class RealNumberTypes
    {
        static void Main()
        {
            byte number = byte.Parse(Console.ReadLine());
           
            if (number<16)
            {
                Console.WriteLine(double.Parse(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine(decimal.Parse(Console.ReadLine()));
            }
           

        }
    }
}
