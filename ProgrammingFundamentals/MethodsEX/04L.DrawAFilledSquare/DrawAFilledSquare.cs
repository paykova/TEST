using System;

namespace _04L.DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSquare(n);

            
        }

        private static void PrintSquare(int n)
        {
            string start = new string('-', 2 * n);
            Console.WriteLine(start);

            for (int j = 0; j < n-2; j++)
            {
                Console.Write("-");
                for (int i = 0; i < n-1; i++)
                {
                    Console.Write("\\");
                    Console.Write("/");

                }
                Console.Write("-");
                Console.WriteLine();

               
            }
            Console.WriteLine(start);
        }
    }
}
