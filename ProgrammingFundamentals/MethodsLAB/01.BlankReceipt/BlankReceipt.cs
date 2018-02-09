using System;

namespace _01.BlankReceipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
           int n = int.Parse(Console.ReadLine());
            PrintReceipt(n);

        }

        private static void PrintReceipt(int n)
        {
            PrintHeader(n);
            PrintBody();
            PrintFooter(n);
        }

        static void PrintFooter(int n)
        {
            PrintDashes(n);
            Console.WriteLine("© SoftUni");
        }

        static void PrintDashes(int n)
        {
            Console.WriteLine(new string('-', n));
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine("CASH RECEIPT");
            PrintDashes(n);
        }
    }
}
