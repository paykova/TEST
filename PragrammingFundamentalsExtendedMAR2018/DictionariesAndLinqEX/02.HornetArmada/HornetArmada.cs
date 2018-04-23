using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HornetArmada
{
    class HornetArmada
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> shortDict = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> longDict = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {
                //{lastActivity} = {legionName} -> {soldierType}:{soldierCount}

                string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                int activity =int.Parse(input[0]);
                string legion = input[1];
                string type = input[2];
                int count = int.Parse(input[3]);



            }

        }
    }
}
