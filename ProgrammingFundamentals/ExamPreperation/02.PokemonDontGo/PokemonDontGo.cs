using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main()
        {
            List<int> elements = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;

            while (elements.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int temp = 0;
                if (index > elements.Count - 1)
                {
                    temp = elements[elements.Count - 1];
                    elements[elements.Count - 1] = elements[0];

                }
                else if (index < 0)
                {
                    temp = elements[0];
                    elements[0] = elements[elements.Count - 1];
                }
                else
                {
                    temp = elements[index];
                    elements.RemoveAt(index);
                }
                sum += temp;


                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i] <= temp)
                    {
                        elements[i] = elements[i] + temp;
                    }
                    else
                    {
                        elements[i] = elements[i] - temp;
                    }
                }

            }
            Console.WriteLine(sum);
        }
    }
}
