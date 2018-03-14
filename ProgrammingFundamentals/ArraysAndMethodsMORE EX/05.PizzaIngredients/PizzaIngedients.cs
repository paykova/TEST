using System;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main()
        {
            string[] ingredients = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int comma = 0;

            for (int i = 0; i < ingredients.Length && count<10; i++)
            {
                if (ingredients[i].Length == n)
                {
                    count++;
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.Write($"The ingredients are: ");
            for (int i = 0; i < ingredients.Length && comma<10; i++)
            {
                if (ingredients[i].Length == n)
                {
                    comma++;
                    if (comma != count)
                    {
                        Console.Write($"{ingredients[i]}, ");
                    }
                    else
                    {
                        Console.Write($"{ingredients[i]}.");
                    }                  
                }
            }
            Console.WriteLine();
        }
    }
}
