﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            bool isEven = number % 2 == 0;

            while (isEven)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
                isEven = number % 2 == 0;
            }
            Console.WriteLine("The number is: {0}", Math.Abs(number));       
        }  
    }
}
