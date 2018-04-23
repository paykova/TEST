using System;
using System.Numerics;

namespace _01.Snowballs
{
    class Snowballs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

           decimal result = 0;
            BigInteger maxResult = 0;
            ulong s = 0;
            ulong t = 0;
            int q = 0;
            for (int i = 0; i < n; i++)
            {
                ulong snow = ulong.Parse(Console.ReadLine());
                ulong time = ulong.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger snowTime = snow / time;
                BigInteger value = BigInteger.Pow(snowTime, quality);

                if (value>maxResult)
                {
                    maxResult = value;
                    s = snow;
                    t = time;
                    q = quality;

                }
                          }
            Console.WriteLine($"{s} : {t} = {maxResult} ({q})");

        }
    }
}
