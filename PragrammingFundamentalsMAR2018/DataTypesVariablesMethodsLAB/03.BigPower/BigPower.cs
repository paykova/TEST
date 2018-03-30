using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _03.BigPower
{
    
    class BigPower
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = BigInteger.Pow(n, n);
            Console.WriteLine(sum);
        }
    }
}
