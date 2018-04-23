using System;

namespace _01.SplinterTrip
{
    class SplinterTrip
    {
        static void Main()
        {
            double tripDistanceMiles = double.Parse(Console.ReadLine());
            double fuelTankCapacity = double.Parse(Console.ReadLine());
            double mileInHeavyWind = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDistanceMiles - mileInHeavyWind;
            double consumption = milesInNonHeavyWinds * 25;

            double consumptionInHeavyWind = mileInHeavyWind * (25 * 1.5);
            // double consumption = (tripDistanceMiles - mileInHeavyWind) * 25;
            double totalConsumption = (consumption + consumptionInHeavyWind);
            totalConsumption += totalConsumption * 0.05 ;
            double diff = Math.Abs(totalConsumption - fuelTankCapacity);
            Console.WriteLine($"Fuel needed: {totalConsumption:F2}L");

            if (totalConsumption <= fuelTankCapacity)
            {
                Console.WriteLine($"Enough with {diff:F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {diff:F2}L more fuel.");
            }
        }
    }
}


