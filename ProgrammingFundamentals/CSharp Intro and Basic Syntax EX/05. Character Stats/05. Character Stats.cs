using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            Console.Write("Health: ");
            Console.Write("|");
            Console.Write(new String('|', health));
            Console.Write(new String('.', (maxHealth - health)));
            Console.WriteLine("|");

            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new String('|', energy));
            Console.Write(new String('.', (maxEnergy - energy)));
            Console.WriteLine("|");



        }
    }
}
