using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            var totalSugar = (volume * sugar) / 100;
            var totalEnergy = (volume * energy) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
