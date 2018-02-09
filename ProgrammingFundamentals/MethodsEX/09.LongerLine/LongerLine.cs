using System;

namespace _09.LongerLine
{
    public class LongerLine
    {
        public static void Main()
        {
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x22 = double.Parse(Console.ReadLine());
            double y22 = double.Parse(Console.ReadLine());
            double x12 = double.Parse(Console.ReadLine());
            double y12 = double.Parse(Console.ReadLine());

            var c1 = (Math.Sqrt((x1 * x1) + (y1 * y1)));
            var c2 = (Math.Sqrt((x2 * x2) + (y2 * y2)));

            var c12 = (Math.Sqrt((x12 * x12) + (y12 * y12)));
            var c22 = (Math.Sqrt((x22 * x22) + (y22 * y22)));

            if (c1 + c2 > c12 + c22)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (c1 + c2 < c12 + c22)
            {
                Console.WriteLine($"({x12}, {y12})({x22}, {y22})");
            }
            //Console.WriteLine($"{c1} - {c2} - {c12} - {c22}");
        }
    }
}
