using System;
using System.Globalization;
using System.Numerics;

namespace _01.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0; 
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsules = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);               
                decimal price = pricePerCapsules * daysInMonth * capsulesCount;               
                sum += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${sum:F2}");
            

        }
    }
}
