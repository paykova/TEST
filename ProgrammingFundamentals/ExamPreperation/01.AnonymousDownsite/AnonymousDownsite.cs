using System;
using System.Numerics;

namespace _01.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main()
        {
            int nWebsites = int.Parse(Console.ReadLine());
            int secuityKey = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < nWebsites; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                Console.WriteLine(name);
                ulong visits = ulong.Parse(info[1]);
                decimal commPricePerVisit = decimal.Parse(info[2]);

                decimal siteLoss = visits * commPricePerVisit;
                sum += siteLoss; 
            }
            BigInteger securityToken = BigInteger.Pow(secuityKey, nWebsites);
            Console.WriteLine($"Total Loss: {sum:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
