using System;

namespace _09.RefactorSpecialNumbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                var number = i;
                var total = 0;

                while (number != 0)
                {
                    var digit = number % 10;
                    number /= 10;
                    total += digit;
                }
                bool isSpecial = false;
                if ((total == 5) || (total == 7) || (total == 11))
                {
                    isSpecial = true;

                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}