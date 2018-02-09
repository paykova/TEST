using System;

namespace _10.CubeProperties
{
    public class Program
    {
        public static void Main()
        {
            double s = double.Parse(Console.ReadLine());
            string formula = Console.ReadLine();

            switch (formula)
            {
                case "volume": Volume(s);
                    break;
                case "face": Face(s);
                    break;
                case "space": Space(s);
                    break;
                case "area": Area(s);
                    break; 
            }
        }

        private static void Area(double s)
        {
            double area = 6 * s * s;
            Console.WriteLine($"{area:F2}");
        }

        private static void Space(double s)
        {
            double space = Math.Sqrt(3)*s;
            Console.WriteLine($"{space:F2}");
        }

        private static void Face(double s)
        {
            double face = Math.Sqrt(2)*s;
            Console.WriteLine($"{face:F2}");
        }

        private static void Volume(double s)
        {
            double volume = s * s * s;
            Console.WriteLine($"{volume:F2}");
        }
    }
}
