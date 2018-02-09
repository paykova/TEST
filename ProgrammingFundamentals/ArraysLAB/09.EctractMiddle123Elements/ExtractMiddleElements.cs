using System;

namespace _09.ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            string[] arrayOfString = text.Split(' ');

            int[] numbers = new int[arrayOfString.Length];
            var n = numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arrayOfString[i]);
            }

            if (n == 1)
            {
                Console.WriteLine("{{ {0} }}", numbers[n - 1]);
            }
            else if (n % 2 == 0)
            {
                Console.Write("{ " + numbers[n / 2 - 1] + ", " + numbers[n / 2] + " }");
                Console.WriteLine();
            }
            else if (n % 2 != 0)
            {
                Console.Write("{ " + numbers[n / 2 - 1] + ", " + numbers[n / 2] + ", " + numbers[n / 2 + 1] + " }");
                Console.WriteLine();
            }
        }
    }
}
