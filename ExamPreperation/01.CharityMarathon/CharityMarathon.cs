using System;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            long truckLength = long.Parse(Console.ReadLine());
            int truckCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long totalRunners = truckCapacity * days;
            long actualRunners = 0; 
            if (totalRunners >= runners)
            {
                actualRunners = runners; 
            }
            else
            {
                actualRunners = totalRunners;
            }

            decimal totalMeters = actualRunners * laps * truckLength;
            decimal km = totalMeters / 1000;
            decimal raisedMoney = km * moneyPerKm;

            Console.WriteLine($"Money raised: {raisedMoney:F2}");




        }
    }
}
