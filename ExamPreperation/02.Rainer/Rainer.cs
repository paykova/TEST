using System;
using System.Linq;

namespace _02.Rainer
{
    class Rainer
    {
        static void Main()
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = elements[elements.Length - 1];
            int[] field = new int[elements.Length - 1];
            int steps = 0;
            bool isWet = false;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                field[i] = elements[i];
            }
            while (true)
            {
                if ((index < 0) && (index > field.Length - 1))
                {
                    break;
                }

                for (int j = 0; j < field.Length; j++)
                {
                    field[j] = field[j] - 1;
                }
                for (int i = 0; i < field.Length; i++)
                {
                    if (field[i] == 0 && index == i)
                    {
                        isWet = true;
                        break;
                    }
                    
                }
                if (isWet)
                {
                    break;
                }
                for (int k = 0; k < field.Length; k++)
                {
                    if (field[k] == 0 && index != k)
                    {
                        field[k] = elements[k];
                    }
                }


              
                int newIndex = int.Parse(Console.ReadLine());
                steps++;
                index = newIndex;
            }
            Console.WriteLine(string.Join(" ", field));
            Console.WriteLine(steps);
        }
    }
}

