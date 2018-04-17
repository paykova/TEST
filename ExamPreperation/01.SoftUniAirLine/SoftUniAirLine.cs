using System;

namespace _01.SoftUniAirLine
{
    class SoftUniAirLine
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal income = 0;
            decimal expenses = 0;
            decimal totalProfit = 0;
            decimal profit = 0;
            decimal totalExpenses = 0;
            decimal totalIncome = 0;

            for (int i = 0; i < n; i++)
            {

                int adultPassengersCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthPassengersCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
                expenses = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;
                profit = income - expenses;

                totalProfit += profit;
                totalExpenses += expenses;
                totalIncome += income;

                if (profit < 0)
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:F3}$.");
                }
                else
                {
                    Console.WriteLine($"You are ahead with {profit:F3}$.");
                }
            }
            decimal average = totalProfit / n;

            Console.WriteLine($"Overall profit -> {totalProfit:F3}$.");
            Console.WriteLine($"Average profit -> {average:F3}$.");
        }
    }
}
