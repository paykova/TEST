using System;
using System.Collections.Generic;
using System.Numerics; 


namespace _01.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();
            decimal sum = 0;
            decimal totalSum = 0; 

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                names.Add(input[0]);
                sum = long.Parse(input[1]) * decimal.Parse(input[2]);
                totalSum += sum; 
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine($"Total Loss: {totalSum:F20}");
            BigInteger securityToken = BigInteger.Pow(securityKey, n); 
            Console.WriteLine($"Security Token: {securityToken}");
           
        }
    }
}
