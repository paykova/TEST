using System;
using System.Linq;

namespace _05.RoundingNumbersAwayFromZero
{
    public class Program
    {
       public static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double[] newArray = new double[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                var temp = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                newArray[i] = temp;
                Console.WriteLine($"{numbers[i]} => {newArray[i]}");
            }
            
        }
    }
}
