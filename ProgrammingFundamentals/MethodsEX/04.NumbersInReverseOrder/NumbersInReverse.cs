using System;
using System.Linq;


namespace _04.NumbersInReverseOrder
{
    public class NumbersInReverse
    {
        public static void Main()
        {

            double number = double.Parse(Console.ReadLine());
            GetReverseNumber(number);
        }

        static void GetReverseNumber(double number)
        {
            string numberAsString = number.ToString();
            string[] conversedString = new string[numberAsString.Length];

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                var currentItem = numberAsString[i];
                Console.Write(currentItem);
            }
            Console.WriteLine();
        }
    }
}