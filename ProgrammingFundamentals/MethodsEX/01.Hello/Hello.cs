using System;

namespace _01.Hello
{
    public class Program
    {
        public static void Main()
        {
            
            PrintGivenName();

        }

        static void PrintGivenName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name +"!");
        }
    }
}
