using System;

namespace _01.Nacepin
{
    class Nacepin
    {
        static void Main()
        {
            double usdPrice = double.Parse(Console.ReadLine());
            double usdWeight = double.Parse(Console.ReadLine());

            double gbpPrice = double.Parse(Console.ReadLine());
            double gbpWeight = double.Parse(Console.ReadLine());

            double cnyPrice = double.Parse(Console.ReadLine());
            double cnyWeight = double.Parse(Console.ReadLine());

            double us = (usdPrice / 0.58) / usdWeight;
            double gbp = (gbpPrice / 0.41) / gbpWeight;
            double cny = (cnyPrice * 0.27) / cnyWeight;

            double min = Math.Min(us, gbp);
            double minMin = Math.Min(min, cny);

            double max = Math.Max(us, gbp);
            double maxMax = Math.Max(max, cny);

            double diff = maxMax - minMin;

            if (minMin == us)
            {
                Console.WriteLine($"US store. {minMin:F2} lv/kg");
                Console.WriteLine($"Difference {diff:F2} lv/kg");
            }
            else if (minMin == gbp)
            {
                Console.WriteLine($"UK store. {minMin:F2} lv/kg");
                Console.WriteLine($"Difference {diff:F2} lv/kg");
            }
            else if (minMin == cny)
            {              
                Console.WriteLine($"Chinese store. {minMin:F2} lv/kg");
                Console.WriteLine($"Difference {diff:F2} lv/kg");
            }
        }
    }
}
