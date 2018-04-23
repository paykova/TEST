using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Wormhole
{
    class Wormhole
    {
        static void Main()
        {
            List<int> wormholes = Console.ReadLine().Split().Select(int.Parse).ToList();
            int steps = 0;
            int index = 0;

            while (index <= wormholes.Count - 1)
            {
                if (wormholes[index] == 0)
                {
                    steps++; 
                }
                else
                {
                    
                    var temp = index;
                    index = wormholes[index];
                    wormholes[temp] = 0;
                    index--; 
                }
                index++;
            }
            Console.WriteLine(steps);

        }
    }
}
