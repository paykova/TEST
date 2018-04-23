using System;
using System.Linq;

namespace _02.Icarus
{
    class Icarus
    {
        static void Main()
        {

            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int damage = 1;

            while (line != "Supernova")
            {
                string[] command = line.Split();
                string direction = command[0];
                int steps = int.Parse(command[1]);
               

               switch (direction)
                {
                    case "right":
                        while (steps-- > 0)
                        {
                            if (index >= elements.Length - 1)
                            {
                                index = 0;
                                damage++;
                                elements[index] = elements[index] - damage;
                                continue;
                            }
                            index++;
                            elements[index] = elements[index] - damage;
                         }
                        break;
                    case "left":
                        while (steps-- > 0)
                        {
                            if (index <= 0)
                            {
                                index = elements.Length - 1;
                                damage++; 
                                elements[index] = elements[index] - damage;
                                continue; 
                            }
                            index--;
                            elements[index] = elements[index] - damage;
                        }
                        break; 
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
