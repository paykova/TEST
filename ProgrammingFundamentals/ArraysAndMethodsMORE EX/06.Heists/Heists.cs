using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Heists
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int jewelsPrice = input[0];
            int goldPrice = input[1];
            int sum = 0;
            int earnings = 0; 
            int countJewels = 0;
            int countGold = 0; 

            string text = Console.ReadLine();

            while(text != "Jail Time")
            {
                string[] textElements = text.Split();
                string random = textElements[0];
                int expences = int.Parse(textElements[1]);
                countJewels = 0;
                countGold = 0;

                foreach (var item in random)
                {
                    if(item == '%')
                    {
                        countJewels++;
                    }
                    if (item == '$')
                    {
                        countGold++;
                    }
                }
                earnings += jewelsPrice * countJewels + goldPrice * countGold; 
                sum += expences;
                text = Console.ReadLine();
            }

            if (earnings >= sum)
            {
                var diff = earnings - sum; 
                Console.WriteLine($"Heists will continue. Total earnings: {diff}.");
            }
            else
            {
                var diff = sum - earnings; 
                Console.WriteLine($"Have to find another job. Lost: {diff}.");
            }

        }
    }
}
