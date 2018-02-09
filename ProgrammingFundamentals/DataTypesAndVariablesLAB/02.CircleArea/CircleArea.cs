using System;

namespace p02.CircleArea
{
    public class CircleArea
    {
        public static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = r * r * Math.PI;
            Console.WriteLine(area);

        }
    }
}