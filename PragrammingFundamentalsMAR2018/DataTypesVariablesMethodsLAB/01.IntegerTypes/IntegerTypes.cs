using System;

namespace _01.IntegerTypes
{
    class IntegerTypes
    {
        static void Main()
        {
            byte n1 = byte.Parse(Console.ReadLine());
            uint n2 = uint.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            decimal n4 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{n1} {n2} {n3} {n4}");


        }
    }
}
