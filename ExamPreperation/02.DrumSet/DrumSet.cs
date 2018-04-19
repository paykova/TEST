using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DrumSet
{
    class DrumSet
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> elements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
           // List<int> copied = elements; 
            int[] copied = new int[elements.Count];  


            for (int i = 0; i < elements.Count; i++)
            {
                copied[i] = elements[i]; 
            }

            string input = Console.ReadLine();

            while (input != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);

                for (int i = 0; i < elements.Count; i++)
                {
                    elements[i] = elements[i] - power;
                    var current = elements[i];
                    var price = copied[i] * 3;

                    if (current< 0)
                    {
                        if (savings >= price)
                        {
                            savings = savings - price;
                            elements[i] = copied[i];
                        }
                        else
                        {
                            current = 0; 
                        }
                       
                    }
                }

                Console.WriteLine(string.Join(" ", elements));
                Console.WriteLine(savings);
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elements.Where(x => x >0)));
            Console.WriteLine($"Gabsy has\n{savings:F2}lv.");

        }
    }
}
