using System;

namespace _11.GeometryCalculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "circle": Circle();
                    break;
                case "square": Square();
                    break;
                case "triangle": Triangle();
                    break;
                case "rectangle": Rectangle();
                    break; 
            }
        }

        private static void Rectangle()
        {
            double heigth = double.Parse(Console.ReadLine());
            double weigth = double.Parse(Console.ReadLine());
            double rectangleArea = heigth * weigth;
            Console.WriteLine($"{rectangleArea:F2}");
        }

        private static void Triangle()
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            double triangleArea = (a * ha) * 0.5;
            Console.WriteLine($"{triangleArea:F2}");
        }

        private static void Square()
        {
            double side = double.Parse(Console.ReadLine());
            double squareArea = side*side;
            Console.WriteLine($"{squareArea:F2}");
        }

        private static void Circle()
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * radius * radius;
            Console.WriteLine($"{circleArea:F2}");
        }
    }
}
