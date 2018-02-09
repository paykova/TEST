using System;

namespace _08.RefactorVolumeOfPyramid
{
    public class RefactorVolumeOfPyramid
    {
        public static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            var volume = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}