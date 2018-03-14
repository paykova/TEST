using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string product = Console.ReadLine();

            while(product != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if(product == names[i])
                    {
                        Console.WriteLine($"{product} costs: {prices[i]}; Available quantity: {quantities[i]}");
                        break;
                    }
                }
                product = Console.ReadLine(); 
            }
        }
    }
}
