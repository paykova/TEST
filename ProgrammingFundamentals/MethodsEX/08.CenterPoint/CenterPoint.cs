using System;

namespace _08.CenterPoint
{
    public class CenterPoint
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            var c1 = (Math.Sqrt((x1 * x1) + (y1 * y1)));
            var c2 = (Math.Sqrt((x2 * x2) + (y2 * y2)));

            if (c1 < c2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (c1 >= c2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
