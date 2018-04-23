using System;

namespace _05.Wormtest
{
    class Wormtest
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine()); // in meters
            int lengthInCentimeters = length * 100;
            double width = double.Parse(Console.ReadLine()); // in centimeters 


            if (lengthInCentimeters % width == 0 || width == 0)
            {
                var sum = lengthInCentimeters * width;
                Console.WriteLine($"{sum:F2}");
            }
            else
            {
                var sum = (lengthInCentimeters / width) * 100;
                Console.WriteLine($"{sum:F2}%");
            }
        }
    }
}
