using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Entertrain
{
    class Entertrain
    {
        static void Main()
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            List<int> someWagons = new List<int>();
            
            

            while (line != "All ofboard!")
            {
                int wagon = int.Parse(line);
                someWagons.Add(wagon);

                if (someWagons.Sum() > locomotivePower)
                {
                   int avr = (int)(someWagons.Average());
                    int temp = 0;
                    int maxResult = int.MaxValue;
                    for (int i = 0; i < someWagons.Count; i++)
                    {
                        if (Math.Abs(someWagons[i] - avr) < maxResult)
                        {
                            maxResult = Math.Abs(someWagons[i] - avr);
                            temp = i;
                        }
                    }
                    someWagons.RemoveAt(temp);
                }
                line = Console.ReadLine();
            }
            someWagons.Insert(0, locomotivePower);
            someWagons.Reverse();
            Console.WriteLine(string.Join(" ", someWagons));
        }
    }
}
