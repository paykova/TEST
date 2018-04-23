using System;

namespace _01.PokeMon
{
    class PokeMon
            {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine()); //power
            long m = long.Parse(Console.ReadLine()); //distance
            long y = long.Parse(Console.ReadLine()); //exhaustionFactor
            long originalN = n; 
            int count = 0;

            while (n>=m)
            {
                if (n == originalN / 2 && y != 0)
                {

                        n = n / y; 

                }
                if (n < m)
                {
                    break; 
                }
                    n = n - m;
                    count++; 
                
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
