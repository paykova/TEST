using System;

namespace _02.MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = GetMax(a, b);
            int biggest = GetMax(max, c);

            Console.WriteLine(biggest);
        }

        private static int GetMax (int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2; 
            }
        }
    }
}
