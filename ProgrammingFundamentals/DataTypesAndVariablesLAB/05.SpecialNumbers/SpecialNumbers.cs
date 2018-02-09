using System;

namespace _05.SpecialNumbers
{
    public class SpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            //986354634736



            for (int i = 1; i <= n; i++)
            {
                var number = i;
                var sum = 0;

                while (number != 0)
                {
                    var currentNumber = number % 10;
                    number /= 10;
                    sum += currentNumber;
                }

                bool isSpecial = false;
                if ((sum == 5) || (sum == 7) || (sum == 11))
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
