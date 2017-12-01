using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());



            if ((0 <= age) && (age <= 18) && (day == "Weekday"))
            {
                Console.WriteLine("12$");
            }
            else if ((18 < age) && (age <= 64) && (day == "Weekday"))
            {
                Console.WriteLine("18$");
            }
            else if ((64 < age) && (age <= 122) && (day == "Weekday"))
            {
                Console.WriteLine("12$");
            }
            else if ((0 <= age) && (age <= 18) && (day == "Weekend"))
            {
                Console.WriteLine("15$");
            }
            else if ((18 < age) && (age <= 64) && (day == "Weekend"))
            {
                Console.WriteLine("20$");
            }
            else if ((64 < age) && (age <= 122) && (day == "Weekend"))
            {
                Console.WriteLine("15$");
            }
            else if ((0 <= age) && (age <= 18) && (day == "Holiday"))
            {
                Console.WriteLine("5$");
            }
            else if ((18 < age) && (age <= 64) && (day == "Holiday"))
            {
                Console.WriteLine("12$");
            }
            else if ((64 < age) && (age <= 122) && (day == "Holiday"))
            {
                Console.WriteLine("10$");
            }
            else if (((day == "Weekday") || (day == "Holiday") || (day == "Weekend")) && ((age < 0) || (age > 122)))
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
