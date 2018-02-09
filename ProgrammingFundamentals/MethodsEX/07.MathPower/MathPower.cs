using System;

namespace _07.MathPower
{
    public class MathPower
    {
        public static void Main()
        {
           double n = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double sum = 1; 

            for (int i = 1; i <= m; i++)
            {
                sum = sum * n;
            }
            Console.WriteLine(sum);
        }
    }
}
