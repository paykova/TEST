using System;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());

            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double berriesKg = double.Parse(Console.ReadLine());
            double berriesPrice = berriesKg / 5;

            double moneyPerSet = 2 * bananaPrice + 4 * eggPrice + berriesPrice;

            int set = guests / 6;
            int set1 = guests % 6;
            double sum = 0;

            if (set1 == 0)
            {
                sum = set * moneyPerSet;
            }
            else
            {
                sum = (set + 1) * moneyPerSet; 
            }

            if (sum <= money)
            {
                double diff = money - sum; 
               Console.WriteLine($"Ivancho has enough money - it would cost {sum:F2}lv.");
            }
            else
            {
                double diff = sum - money; 
               Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:F2}lv more.");
            }

        }
    }
}
