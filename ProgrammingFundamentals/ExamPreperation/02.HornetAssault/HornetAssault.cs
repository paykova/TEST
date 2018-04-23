using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HornetAssault
{
    class HornetAssault
    {
        static void Main()
        {
            List<long> beehive = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            long totalHornets = hornets.Sum();

            for (int i = 0; i < beehive.Count; i++)
            {
                if (beehive[i] < totalHornets)
                {
                    beehive[i] = 0;
                }
                else
                {
                    beehive[i] = beehive[i] - totalHornets;
                    totalHornets = totalHornets - hornets[0];
                    hornets.RemoveAt(0);                   
                }
                if (hornets.Count == 0)
                {
                    break; 
                }
            }
            if (beehive.Any(i => i!=0))
            {
                for (int i = 0; i < beehive.Count; i++)
                {
                    if (beehive[i] > 0)
                    {
                        Console.Write(beehive[i] + " ");
                    }
                }
                Console.WriteLine();
               
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
